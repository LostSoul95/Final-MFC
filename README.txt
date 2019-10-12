Q1. Find third largest integer in an array using only one loop. The user will input an unsorted integer array and  the method should find the third largest integer in the array.
   
   input: 3 2 1 5 4, output: 3


Ans 1 . The file to be referred - third_largest.cs

        We use only one for loop for this process

        Logic - 1.) Check the size of the array it should be greater than 3.If yes, continue else               exit.
                2.) If the size of the array is less than 3, initiliaze three variables first,          second and third, with first equal to the first element(zero index) of the          input array, and second and third equal to the lowest integral value               possible.
                3.) Run a for loop from the second element(index=1) till the last element.

                4.) If the current element is greater than first,then update first, second and          third in such a manner that first is now equal to the value of the current          element in the iteration, second is equal to the old value of the first 
                    element and third is equal to old value of second element.

                5.) If the current element is smaller than first,but greater than second, then          value of second element is equal to the value of current element,and value of       third element is equal to value of the second element.

                6.) If the current element is smaller than second,but greater than third, then          value of third element is equal to value of the current element.

Q2. Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
   Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock. Noon is 12:00:00PM on a 12-hour clock, 
   and 12:00:00 on a 24-hour clock.
   
   Sample Input: 07:05:45PM
   Sample Output: 19:05:45

Ans 2. The file to be referred - hourclock.cs

        Logic -  1.) The input has to be in this format HH:MM:SSAM/PM
                 2.) The 9th element or the 8th index is either a letter A or P,else it is an 
                     invalid input from the user.
                 3.) The hour of the input is derived by using the subsring function in which the       starting index is the first element or index Zero, and the total length of 
                        the substring is zero.
                 4.) If the 9th element is 'A', and hour is 12, hour in that case becomes zero and      for the rest hours left in AM, no value is changed and we calculate the time        by concatenating hours with rest of the substring till seconds( substring         start at index second and end at index seven).
                 5.)   If the 9th element is 'P', and hour is 12, hour in that case remains 12             and for the rest hours left in PM, the hour input increases by 12 and we          calculate the time by concatenating hours with rest of the substring              till  seconds( substring start at index second and end at index seven.


Q3.  Given two strings, determine if they share a common substring. A substring may be as small as one character.
   For example, the words "a", "and", "art" share the common substring a. The words "be" and "cat" do not share a substring.
   The function should return a string, either YES or NO based on whether the strings share a common substring.
   
Sample Input
	2
	hello
	world
	hi
	world

Sample Output

	YES
	NO

Explanation
We have p= 2 pairs to check:

1. s1="hello",s2="world". The substrings "o" and "l" are common to both strings.
2. a="hi",b="world". a and b share no common substrings.


Ans 3. The file to be referred - common_Subtring.cs

LOGIC


    1.) Understanding that a single character is a valid substring.
    2.) Deducing that we only need to know that the two strings have a common substring — we don't      need to know what that substring is.

    Thus, the key to solving this is determining whether or not the two strings share a common character because if they have a common character then they have a common substring of length 1.

    To do this, we created two hash sets,  and , where each set contains the unique characters that appear in the string it's named after. Because sets don't store duplicate values, we know that the size of our sets will never exceed the letters of the English alphabet.

    If the intersection of the two sets is empty, we print NO ; if the intersection of the two sets is not empty, then we know that strings  share one or more common characters and we print YES on a new line.
