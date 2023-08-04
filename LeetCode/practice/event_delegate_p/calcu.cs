using System;

namespace ConsoleApp2.practice.event_delegate_p
{
    public class calcu{
        public delegate float OperationDelegate(float num, float num2);
        
        public static float Add(float num, float num2){
            return num + num2;
        }
        public static float Subtract(float num, float num2)
        {
            return num - num2;
        }
        public static float Multiply(float num, float num2)
        {
            return num * num2;
        }
        public static float Divide(float num, float num2)
        {
            return num / num2;
        }
        
        public static float ApplyOperation(string symbol,float num, float num2){
            switch (symbol){
                case "+":
                    return Add(num, num2);
                case "-":
                    return Subtract(num, num2);
                case "*":
                    return Multiply(num, num2);
                case "/":
                    return Divide(num, num2);
                default:
                    return 0;
            }
        }
        public static float ApplyOperation2(OperationDelegate oper, float num, float num2){
                 return oper(num, num2);
        }

    }
}