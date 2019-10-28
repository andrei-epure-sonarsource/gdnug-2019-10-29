namespace NetStandard
{
    public class NonStaticLocal
    {
        public int Foo(int number)
        {
            // an internal class is created to store the captured var
            return Multiply(number);

            // look at c__DisplayClass0_0 which gets passed
            // TODO : pass parameter and make it static
            // and look again at the IL
            static int Multiply(int number)
            {
                return number * 10;
            }
        }
    }
}