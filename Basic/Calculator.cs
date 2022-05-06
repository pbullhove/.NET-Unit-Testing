using System;

namespace BasicProgram
{
    public class Calculator
    {
        public int? Add(int? a, int? b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();

            return a + b;
        }

        
    }

}
