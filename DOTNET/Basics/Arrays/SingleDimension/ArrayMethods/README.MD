# Array extention methods (without using existing arrays methods)

- Create methods with the following names that receives  int[] arr and int i as arguments and return an array or null

1. Append - return new array after return the arr after appending i ,example: ({1,2},3)={1,2,3} , if arr is null or empty return {i}.
2. GetIndexes - returns items indexes the equals to i, if not found return null,
   example :({1,4,1,5,9,2},1) ={0,2} , ({1,4,1,5,9,2},3) =null.
3. GetItemsAbove - returns items above i, if not found return null ,example: ({1,4,1,5,9,2},4) = {5,9},:({1,4,1,5,9,2},31) = null
4. GetItemsExcept - return items except item , example: ({1,4,1,5,9,2},1) = {4,5,9,2}
5. GetAllContains - return all items that contains the item ,example: ({11,4,15,5,1,29,2},1) = {11,15,1}, if not found return null
6. GetSorted - return array sorted in ascending order , example: ({ 3, 2, 1 }) = { 1, 2, 3 }
7. AreItemsSame -receives  int[] arr and returns boolean indicates true if all items are same otherwise false , example :({1,4,1}) =false, ({4,4,4}) =true , null or empty arr = true
