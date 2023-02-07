// class  b_search{
//     static int binarySearch(int[] arr, int l, int r, int x)
//     {
//         if (r >= l) {
//             int mid = l + (r - l) / 2;
 
         
//             if (arr[mid] == x)
//                 return mid;
 
       
//             if (arr[mid] > x)
//                 return binarySearch(arr, l, mid - 1, x);
 
      
//             return binarySearch(arr, mid + 1, r, x);
//         }
//         return -1;
//     }
 

//     public static void Main()
//     {
 
//         int[] arr = { 2, 3, 4, 10, 40 };
//         int n = arr.Length;
//         int x = 10;
 
//         int result = binarySearch(arr, 0, n - 1, x);
 
//         if (result == -1)
//             Console.WriteLine("Element not present");
//         else
//             Console.WriteLine("Element found at index "
//                               + result);
//     }
// }
 
// class MergeSort {
 
   
//     void merge(int[] arr, int l, int m, int r)
//     {
   
//         int n1 = m - l + 1;
//         int n2 = r - m;
 
   
//         int[] L = new int[n1];
//         int[] R = new int[n2];
//         int i, j;
 
       
//         for (i = 0; i < n1; ++i)
//             L[i] = arr[l + i];
//         for (j = 0; j < n2; ++j)
//             R[j] = arr[m + 1 + j];
 
       
//         i = 0;
//         j = 0;
 

//         int k = l;
//         while (i < n1 && j < n2) {
//             if (L[i] <= R[j]) {
//                 arr[k] = L[i];
//                 i++;
//             }
//             else {
//                 arr[k] = R[j];
//                 j++;
//             }
//             k++;
//         }
 
        
//         while (i < n1) {
//             arr[k] = L[i];
//             i++;
//             k++;
//         }
 
      
//         while (j < n2) {
//             arr[k] = R[j];
//             j++;
//             k++;
//         }
//     }
 
//     void sort(int[] arr, int l, int r)
//     {
//         if (l < r) {
     
//             int m = l + (r - l) / 2;
 
     
//             sort(arr, l, m);
//             sort(arr, m + 1, r);
 
//             merge(arr, l, m, r);
//         }
//     }
 

//     static void printArray(int[] arr)
//     {
//         int n = arr.Length;
//         for (int i = 0; i < n; ++i)
//             Console.Write(arr[i] + " ");
//         Console.WriteLine();
//     }
 
  
//     public static void Main(String[] args)
//     {
//         int[] arr = { 12, 11, 13, 5, 6, 7 };
//         Console.WriteLine("Given Array");
//         printArray(arr);
//         MergeSort ob = new MergeSort();
//         ob.sort(arr, 0, arr.Length - 1);
//         Console.WriteLine("\nSorted array");
//         printArray(arr);
//     }
// }

namespace sample{
    public class test{
        public static void Main(){
            List<int> ls= new List<int> (){
                1,2,3,4,5,6,7,9,11
            };
            ls.Add(10);
            ls.Add(12);
            ls.Add(13);
            ls.Add(14); 
            Console.WriteLine("size of list is-"+ ls.Count);
            ls.Insert(4,5);
            ls.IndexOf(5);
            Console.WriteLine("element is present?"+ ls.Contains(5)); 
           
            Console.WriteLine("element exist?"+ ls.Exists(ls=>ls.Equals(3)));
            int[] arr=new int[3];
            arr[0]=1;
            arr[1]=2;
            arr[2]=3;
            List<int> list=arr.ToList();
            list[3]=5;
    }
}
}
