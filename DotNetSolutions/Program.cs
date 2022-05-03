using System;

namespace DotNetSolutions {
    public class Program {
        public static void Main(string[] args)
        {
            var testCase = new
            {
                //Input = "Let's take LeetCode contest",
                //Output = "s'teL ekat edoCteeL tsetnoc"
                Input = "God Ding",
                Output = "doG gniD"
            };
            var result = DotNetSolutions.TwoPointers.ReverseWords(testCase.Input);            
            //Console.WriteLine("DotNetSolutions");
        }
    }    
}