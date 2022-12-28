
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Net;
using System.Net.Cache;

class Program
{
    static Dictionary<string, UrlStatistics> UrlsStatistics = new Dictionary<string, UrlStatistics>();
    static async Task Main(string[] urls)
    {
        long durationMS = 0;
        Initialize(urls);
        //SYNC
        durationMS = SetUrlsStatistics(UrlsStatistics);
        DisplayUrlsStatistics("*SYNC", UrlsStatistics, durationMS);
        //ASYNC
        Console.WriteLine("*************");
        durationMS = SetUrlsStatistics_Task(UrlsStatistics);
        DisplayUrlsStatistics("*ASYNC Task", UrlsStatistics, durationMS);
        //
        durationMS = SetUrlsStatistics_ParallelForEach(UrlsStatistics);
        DisplayUrlsStatistics("*ASYNC ParallelForEach", UrlsStatistics, durationMS);
        //
        durationMS = SetUrlsStatistics_ParallelInvoke(UrlsStatistics);
        DisplayUrlsStatistics("*ASYNC ParallelInvoke", UrlsStatistics, durationMS);
        //
        durationMS = SetUrlsStatistics_ParallelFor(UrlsStatistics);
        DisplayUrlsStatistics("*ASYNC ParallelFor", UrlsStatistics, durationMS);
        //
        durationMS = await SetUrlsStatistics_Await(UrlsStatistics);
        DisplayUrlsStatistics("*ASYNC async await", UrlsStatistics, durationMS);
    }
    //
    private static void DisplayUrlsStatistics(string title, Dictionary<string, UrlStatistics> urlsStatistics, long durationMS)
    {
        Console.WriteLine($"{title} download urls statistics:");
        foreach (var urlStatistics in UrlsStatistics)
            Console.WriteLine(urlStatistics.Value);
        Console.WriteLine($"Total downloads duration took {durationMS} ms");
    }
    //
    private static long SetUrlsStatistics(Dictionary<string, UrlStatistics> urlsStatistics)
    {
        long durationMS = 0;
        foreach (var urlStatistics in urlsStatistics)
        {
            SetUrlStatistics(urlStatistics.Value);
            durationMS += urlStatistics.Value.DownloadDuration;
        }
        return durationMS;
    }

    private static async Task<long> SetUrlsStatistics_Await(Dictionary<string, UrlStatistics> urlsStatistics)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        List<Task> actions = new List<Task>();
        foreach (var urlStatistics in urlsStatistics)
            actions.Add(SetUrlStatistics_ASYNC(urlStatistics.Value));
        //
        foreach (var a in actions)
            await a;
        return stopwatch.ElapsedMilliseconds;
    }

    private static long SetUrlsStatistics_Task(Dictionary<string, UrlStatistics> urlsStatistics)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        List<Task> actions = new List<Task>();
        foreach (var urlStatistics in urlsStatistics)
            actions.Add(Task.Run(() => SetUrlStatistics(urlStatistics.Value)));
        Task.WaitAll(actions.ToArray());
        return stopwatch.ElapsedMilliseconds;
    }

    private static long SetUrlsStatistics_ParallelForEach(Dictionary<string, UrlStatistics> urlsStatistics)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        Parallel.ForEach<UrlStatistics>(urlsStatistics.Values, SetUrlStatistics);
        return stopwatch.ElapsedMilliseconds;
    }

    private static long SetUrlsStatistics_ParallelInvoke(Dictionary<string, UrlStatistics> urlsStatistics)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        List<Action> actions = new List<Action>();
        foreach (var urlStatistics in urlsStatistics)
            actions.Add(() => SetUrlStatistics(urlStatistics.Value));
        Parallel.Invoke(actions.ToArray());
        return stopwatch.ElapsedMilliseconds;
    }

    private static long SetUrlsStatistics_ParallelFor(Dictionary<string, UrlStatistics> urlsStatistics)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        List<Action> actions = new List<Action>();
        foreach (var urlStatistics in urlsStatistics)
            actions.Add(() => SetUrlStatistics(urlStatistics.Value));
        Parallel.For(0, actions.Count, (i) => actions[i]());
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    private static Task SetUrlStatistics_ASYNC(UrlStatistics urlStatistics)
    {
        return Task.Run(() =>
        {
            WebClient webClient = new WebClient();
            Stopwatch sw = Stopwatch.StartNew();
            urlStatistics.Data = webClient.DownloadString(urlStatistics.Url);
            urlStatistics.Size = urlStatistics.Data.Length;
            sw.Stop();
            urlStatistics.DownloadDuration = sw.ElapsedMilliseconds;
        });
    }

    private static void SetUrlStatistics(UrlStatistics urlStatistics)
    {
        var html = new HtmlDocument();
        WebClient webClient = new WebClient();
        Stopwatch sw = Stopwatch.StartNew();
        webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
        urlStatistics.Data = webClient.DownloadString(urlStatistics.Url);
        urlStatistics.Size = urlStatistics.Data.Length;

        sw.Stop();
        urlStatistics.DownloadDuration = sw.ElapsedMilliseconds;
    }

    private static void Initialize(string[] urls)
    {
        if (urls != null && urls.Length > 0)
        {
            if (urls.Length == 1)
                urls = urls[0].Split(' ');
        }
        else//set default
            urls = new string[] { "https://ynet.co.il", "https://msn.co.il", "https://walla.co.il" };
        //
        foreach (string url in urls)
            UrlsStatistics.Add(url, new UrlStatistics() { Url = url });
    }
}

class UrlStatistics
{
    public string Url { get; set; }
    public int Size { get; set; }
    public long DownloadDuration { get; set; }
    public string Data { get; set; }
    IEnumerable<HtmlNode> A_Nodes
    {
        get
        {
            return Get_A_Nodes();
        }
    }

    public IEnumerable<HtmlNode> Get_A_Nodes()
    {
        HtmlDocument html = GetHtmlDocument();
        return html.DocumentNode.QuerySelectorAll("a");
    }


    public IEnumerable<HtmlNode> Get_Tel_Nodes()
    {
        HtmlDocument html = GetHtmlDocument();
        return html.DocumentNode.QuerySelectorAll("a=tel:");
    }


    public HtmlDocument GetHtmlDocument()
    {
        if (Data == null)
            return null;
        var html = new HtmlDocument();
        html.LoadHtml(Data);
        return html;
    }


    public override string ToString()
    {
        return $"{Url},contains {Size} bytes ,a count {A_Nodes.Count()},took {DownloadDuration} ms";
    }
}