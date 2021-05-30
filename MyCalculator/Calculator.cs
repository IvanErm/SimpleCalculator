using System;

namespace MyCalculator
{
    public class Calculate
    {
        public double FirstOperand { get; set; }
        public double SecondOperand { get; set; }
        public double Result { get; set; }
        public ArithmeticOperation Operation { get; set; }

        public string OperationTostring()
        {
            switch (Operation)
            {
                case ArithmeticOperation.Sum:
                    return "+";  
                
                case ArithmeticOperation.Sub:
                    return "-";       
                
                case ArithmeticOperation.Div:
                    return "÷";

                default:
                    return "*";
            }
        }

        public double Add()
        {
            return FirstOperand + SecondOperand;
        }   
        
        public double Sub()
        {
            return FirstOperand - SecondOperand;
        }  
        
        public double Mult()
        {
            return FirstOperand * SecondOperand;
        }    
        
        public double Div()
        {
            return FirstOperand / SecondOperand * 1.0;
        }

    }
}
