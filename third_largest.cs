using System; 
  
public class ThirdLargestSingleLoop 
{
	static void thirdLargest(int []input, int input_size) 
	{ 

        // Size of the array should be greater than three.

        if(input_size<3)
        {
            Console.WriteLine("The input array should be greater than 3");
            return;
        }
        
        else
        {


            // Initialize the elements

            int first_ele = input[0];
            int second_ele = int.MinValue;
            int third_ele= int.MinValue;

             // Traverse array elements to find the third Largest element.

            for(int i = 1; i< input_size; i++ )

            {


                 // If the current element is greater than first, 
                 // then update first, second and third 

                if(input[i] > first_ele)
                {
                     third_ele = second_ele;
                     second_ele = first_ele;
                     first_ele = input[i];

                }

                  // If the current item in the input array(input[i]) in between first and second 

                else if (input[i] > second_ele )
                {
                    third_ele =  second_ele;
                    second_ele = input[i];
                }

                 // If the current item in the input array (input[i]) is in between second and third 

                else if (input[i] >  third_ele)
                {
                    third_ele = input[i];
                }

            }


             Console.Write("The third Largest element is "+ third_ele); 

        }

       
    }

    public static void Main()
    {
        // Manually set the array for this use case.

        int []input = {3, 2, 1, 5 ,4};

        //  find the size of the array.

        int input_size = input.Length;

        // Call the above function and find the third largest element.

        thirdLargest(input,input_size);

    }
} 