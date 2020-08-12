using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Auto.FilePath
{
   public class FilePath
    {
        private static string SolutionPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        public static string drivers =  SolutionPath + "\\Driver";
        //  @"C:\Users\codibo\source\repos\MyCSharpProject\UnitTestProject7\Driver";
        //file C:\Users\codibo\source\repos\MyCSharpProject\UnitTestProject7\bin\Driver
    }
}
