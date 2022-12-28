# Urls sync vs async speed comparison report
1. Create an array of several urls 
2. Create an application that recieves an url and downloads its content and stores the download size and speed.
3. Use the urls to download their contents and measure the total download speed inside sync method 
4. Use the urls to download their contents and measure the total download speed async methods (one using Task,Parallel.Invoke|For|ForEach, async await)
5. Add links (a tag) count to each statistics (you can you Fizzler package to parse the html)
* Print the sync & async methods outputs to a report like the following :

<pre>
*SYNC download urls statistics:
https://ynet.co.il,contains 380006 bytes ,a count 391,took 1170 ms
https://msn.co.il,contains 37954 bytes ,a count 88,took 1768 ms
https://walla.co.il,contains 724525 bytes ,a count 467,took 566 ms
Total downloads duration took 3504 ms
*************
*ASYNC Task download urls statistics:
https://ynet.co.il,contains 380006 bytes ,a count 391,took 398 ms
https://msn.co.il,contains 37601 bytes ,a count 88,took 717 ms
https://walla.co.il,contains 724525 bytes ,a count 467,took 270 ms
Total downloads duration took 718 ms
*ASYNC ParallelForEach download urls statistics:
https://ynet.co.il,contains 380006 bytes ,a count 391,took 381 ms
https://msn.co.il,contains 37758 bytes ,a count 88,took 598 ms
https://walla.co.il,contains 724525 bytes ,a count 467,took 245 ms
Total downloads duration took 609 ms
*ASYNC ParallelInvoke download urls statistics:
https://ynet.co.il,contains 380006 bytes ,a count 391,took 415 ms
https://msn.co.il,contains 37999 bytes ,a count 88,took 604 ms
https://walla.co.il,contains 724525 bytes ,a count 467,took 265 ms
Total downloads duration took 607 ms
*ASYNC ParallelFor download urls statistics:
https://ynet.co.il,contains 380006 bytes ,a count 391,took 341 ms
https://msn.co.il,contains 38194 bytes ,a count 88,took 546 ms
https://walla.co.il,contains 724525 bytes ,a count 467,took 201 ms
Total downloads duration took 547 ms
*ASYNC async await download urls statistics:
https://ynet.co.il,contains 379851 bytes ,a count 391,took 270 ms
https://msn.co.il,contains 37922 bytes ,a count 88,took 693 ms
https://walla.co.il,contains 722530 bytes ,a count 454,took 1742 ms
Total downloads duration took 1742 ms
</pre>