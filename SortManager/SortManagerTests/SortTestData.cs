using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortManagerModel;

namespace SortManagerTests;

internal class SortTestData
{
    public static object[] PosArrays =
    {
        new int [][] { new int[] { 2,1,3,4}, new int[] { 1,2,3,4} },
        new int [][] { new int[] {1}, new int[] { 1} },
        new int [][] {new int[] {2,1,2}, new int[] {1,2,2} },
        new int [][] {new int[] {5,3,2,4,1,5,6,6}, new int[] {1,2,3,4,5,5,6,6} }
    };
    public static object[] EmptArray =
    {
        new int [][] {new int[] {}, new int[] {} },
    };
    public static object[] NegandPosArrays =
    {
        new int [][] { new int[] { 2,1,-3,-4}, new int[] { -4,-3,1,2} },
        new int [][] { new int[] {-1}, new int[] { -1} },
        new int [][] {new int[] {2,-1,2}, new int[] {-1,2,2} },
        new int [][] {new int[] {5,3,-2,4,1,-5,6,6}, new int[] {-5, -2,1,3,4,5,6,6} }
    };

}
