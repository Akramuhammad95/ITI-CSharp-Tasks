namespace Day2.calulator
{
    class Devide : IOperation
    {
        public float DoOperation(float n1, float n2)
        {
            try
            {
                return n1 / n2;
            }
            catch (DivideByZeroException)
            {
                return 0.0f;
            }
        }
    }
}



