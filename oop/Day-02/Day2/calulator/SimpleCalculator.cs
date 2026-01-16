namespace Day2.calulator
{
    partial class SimpleCalculator
    {
        private float _num1;
        private float _num2;
        public SimpleCalculator(float num1 , float num2 )
        {
            
            _num1 = num1;
            _num2 = num2;
            
        }

        public float DoOperation( IOperation operation ) 
        {
            return operation.DoOperation(_num1 , _num2);
        }
    }


    
    
    
}

