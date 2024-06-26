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

    public static int sockMerchant(int n, List<int> ar)
    {   
        var sockcount = 0;
        var a = new List<int>();
        foreach(var i in ar){
            
            if(!a.Contains(i)){
                a.Add(i);
            }
            else{
                sockcount++;
                a.Remove(i);
            }
        }
        return sockcount;
    }

}
