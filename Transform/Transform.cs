using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public delegate int converter(int x);

    public static class Transform
    {
        public static List<int> Map(this int[] values , converter convert)
        {

            List<int> converted_values = new List<int>();
            foreach (int item in values)
            {
                converted_values.Add(convert(item));
            }


            return converted_values;


            throw new NotImplementedException();
        }
    }
}
