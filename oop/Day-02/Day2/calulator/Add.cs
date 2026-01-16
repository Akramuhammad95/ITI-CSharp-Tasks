namespace Day2.calulator
{

    class Add : IOperation
    {
        public float DoOperation(float n1, float n2)
        {
            return n2 + n1;


        }
    }

    class Multibly : IOperation
    {
        public float DoOperation(float n1, float n2)
        {
            return n1*n2;
        }
    }
}



