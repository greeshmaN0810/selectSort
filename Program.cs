/*
Author: Greeshma Namana
Date: 02/28/2024
Comments: This C# Console Application code demonstrates the
   Selection Sort. 
*/
int[] selection_sort_numbers = { 5,72,3,14,7,1};
Console.WriteLine("Here is the original array that will be used to execute the Selection Sort Algorithm: ");
for (int i = 0; i < selection_sort_numbers.Length; i++)
{
    Console.Write("  " + selection_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Here is the array after the execution of the Selection Sort Algorithm: ");
Selection_Sort(selection_sort_numbers);
Console.WriteLine("");

static void Selection_Sort(int[] ss_arr)
{
    // min_position is being used here to keep track of lowest number 
    int min_position;
    // temp is used for swapping 
    int temp;

    for (int i = 0; i < ss_arr.Length; i++)
    {
        // initialize the min position
        min_position = i;
        // checking if the next element is smaller 
        for (int x = i + 1; x < ss_arr.Length; x++)
        {
            //if smaller, make the min number the new min
            if (ss_arr[x] < ss_arr[min_position])
            {
                //min_position will keep track of the index that min is in, this is needed when a swap happens
                min_position = x;
            }
        } // End of inner for loop

        // If the min_position does not equal the current element being evaluated in the loop
        // Then execute the swap. by switching the postion of the lowest with the current element
        if (min_position != i)
        {
            temp = ss_arr[i];
            ss_arr[i] = ss_arr[min_position];
            ss_arr[min_position] = temp;
        }
        Console.Write("  " + ss_arr[i]);
    } // End of outer for loop
} // End of Selection_Sort
