namespace FCC
{
    public class FCCMath
    {
        public int multiply(int m1, int m2)
        {
            MulHelper1 mh1 = new();
            int t1 = mh1.multiply(m1, m2);
            MulHelper2 mh2 = new();
            int t2 = mh2.multiply(m1, m2);
            return m1 * m2;
        }

        internal class MulHelper1
        {
            public int multiply(int m1, int m2)
            {
                return m1 * m2;
            }
        }
    }
    internal class MulHelper2
    {
        public int multiply(int m1, int m2)
        {
            return m1 * m2;
        }
    }
}
