public class Kata
{
  public static string AbbrevName(string name)
  {
    string[] words = name.Split(' ');

            return (words[0][0] + "." + words[1][0]).ToUpper();
  }
}


///and the second solution has been tested on my vs
static string AbbrevName(string name)
{
    string[] words = name.Split(' ');//create array and split string into 2 parts
    Console.WriteLine(words[1][0]); //cheking testing result 
    return (words[0][0] + "." + words[1][0]).ToUpper(); //return finish result 
    
}
Console.WriteLine(AbbrevName("Tikhonov artur")); //call method and send parametr.

////////////////
////INSTRUCTION Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

///The output should be two capital letters with a dot separating them.

////It should look like this:

////Sam Harris => S.H

////patrick feeney => P.F
