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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        double positive = 0;
        double negative = 0;
        double zeroes = 0;
        double total = arr.Length;
        for (int i = 0;i < total; i++) {
            if (arr[i] > 0) {
                positive += 1;
            }
            else if (arr[i] < 0) {
                negative += 1;
            }
            else {
                zeroes += 1;
            }
        }
        Console.WriteLine("{0}", positive / total);
        Console.WriteLine("{0}", negative / total);
        Console.WriteLine("{0}", zeroes / total);        
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
