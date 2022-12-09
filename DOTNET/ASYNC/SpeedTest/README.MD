# Urls sync vs async speed comparison report
* Create an array of several urls 
* Create an application that recieves an url and downloads its content and stores the download size and speed.
* Use the urls to download their contents and measure the total download speed inside sync method 
* Use the urls to download their contents and measure the total download speed async methods (one using Task,Parallel.Invoke|For|ForEach, async await)
* Print the sync & async methods outputs to a report like the following :

<pre>
*SYNC download urls statistics:
https://ynet.co.il,contains 395035 bytes,took 1352 ms
https://msn.co.il,contains 37312 bytes,took 1664 ms
https://walla.co.il,contains 722080 bytes,took 915 ms
Total downloads duration took 3931 ms
*************
*ASYNC Task download urls statistics:
https://ynet.co.il,contains 395210 bytes,took 1145 ms
https://msn.co.il,contains 37800 bytes,took 583 ms
https://walla.co.il,contains 722080 bytes,took 359 ms
Total downloads duration took 1147 ms
*ASYNC ParallelForEach download urls statistics:
https://ynet.co.il,contains 395210 bytes,took 387 ms
https://msn.co.il,contains 37473 bytes,took 537 ms
https://walla.co.il,contains 722080 bytes,took 334 ms
Total downloads duration took 566 ms
*ASYNC ParallelInvoke download urls statistics:
https://ynet.co.il,contains 395210 bytes,took 377 ms
https://msn.co.il,contains 37534 bytes,took 531 ms
https://walla.co.il,contains 722080 bytes,took 341 ms
Total downloads duration took 533 ms
*ASYNC ParallelFor download urls statistics:
https://ynet.co.il,contains 395210 bytes,took 453 ms
https://msn.co.il,contains 37648 bytes,took 571 ms
https://walla.co.il,contains 722080 bytes,took 263 ms
Total downloads duration took 572 ms
*ASYNC async await download urls statistics:
https://ynet.co.il,contains 395210 bytes,took 423 ms
https://msn.co.il,contains 37627 bytes,took 591 ms
https://walla.co.il,contains 722080 bytes,took 373 ms
Total downloads duration took 593 ms
</pre>