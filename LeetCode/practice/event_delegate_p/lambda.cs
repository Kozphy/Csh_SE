using System;

namespace ConsoleApp2.practice.event_delegate_p
{
    public class lambda_p
        {
        static Func<int, int, int> Plus = (num, num2) => {return num + num2;};
        
        static Func<int,int,int> Minus = (num, num2) => {return num - num2;};
        static Func<int,int,int> Divide = (num, num2) => {return num/num2;};
        static Func<int,int,int> Multiply = (num,num2) => {return num*num2;};
        
        public static  Dictionary<string, Func<int,int,int>> calc = new Dictionary<string, Func<int,int,int>>()
        {
            {"+", Plus},
            {"-", Minus},
            {"/", Divide},
            {"*", Multiply}
        };
        
        public static Func<int,int,int> OperationGet(string input)
        {
            if (calc.ContainsKey(input))
            {
                return calc[input];
            }
            return null;
        }

    }
        
    
}