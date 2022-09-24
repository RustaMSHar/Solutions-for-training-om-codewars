//INSTRUCTION
//Given a non-empty array of integers, return the result of multiplying the values together in order. Example:

//[1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24

//SOLUTION
using System.Linq;
public class Kata
{
  public static int Grow(int[] x)
  {
     return x.Aggregate((p, next) => p * next);
  }
}
