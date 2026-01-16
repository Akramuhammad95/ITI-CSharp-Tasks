namespace Day2.calulator
{
    static class CalculatorExtensions
    {
        static char[]  _operators = new char[] { '+', '-', '*', '/' };
           
            static public bool IsValidOperator(char op)
        {
            foreach (var item in _operators)
            {
                if (item == op)
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsZeroDevision(float n)
        {
            return n == 0;
        }
    }


    
}

