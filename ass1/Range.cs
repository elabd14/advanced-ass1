using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1
{

    public class Range<T> where T : IComparable<T>
    {
        private T min;
        private T max;

  
        public Range(T minValue, T maxValue)
        {
            if (minValue.CompareTo(maxValue) > 0)
            {
                throw new ArgumentException("Minimum value must be less than or equal to maximum value.");
            }
            min = minValue;
            max = maxValue;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

      
        public T Length()
        {
            dynamic minValue = min;
            dynamic maxValue = max;
            return maxValue - minValue;
        }



    }

}
