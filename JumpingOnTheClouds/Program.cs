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

    public static int jumpingOnClouds(List<int> c)
    {
        int i = 0;
        int counter = 0;
        while(i < c.Count -1){
            if(i+2 < c.Count && c[i+2] == 0 ){
                i = i+2;
                counter++;
            }
            else{
                i++;
                counter++;
            }
        }
        return counter;
    }

}
