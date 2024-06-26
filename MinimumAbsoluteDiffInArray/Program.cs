using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int minimumAbsoluteDifference(List<int> arr)
    {
        int min = int.MaxValue;
        arr.Sort();
        for(int i = 0; i < arr.Count-1; i++){
            if(Math.Abs(arr[i] - arr[i+1]) < min){
                min = Math.Abs(arr[i] - arr[i+1]);
            }
        }
        
        
        return min;
    }

}