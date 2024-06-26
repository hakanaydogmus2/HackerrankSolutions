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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        
        for(int i=0; i<grades.Count; i++){
            
            var tempGrade = grades[i];
            
            while(!(tempGrade % 5 == 0)){
                tempGrade++;
            }
            var dif = tempGrade - grades[i];
            
            if(grades[i] < 40 && 40 - grades[i] < 3){
                grades[i] = 40;
            }
            else if(grades[i] > 40 && dif<3){
                grades[i] = tempGrade;
            }
        }
        return grades;
    }

}