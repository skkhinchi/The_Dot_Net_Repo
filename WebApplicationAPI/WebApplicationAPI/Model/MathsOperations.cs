namespace WebApplicationAPI.Model
{
    interface IMath
    {
        abstract int Multiply(int a, int b);
        abstract int Divide(int a, int b);
        abstract int Substract(int a, int b);
        abstract int Add(int a, int b);

    }

    public class MathsOperation : IMath
    {
       

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            
            return a / b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
