using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingGeneral
{
    static class Serializer
    {
        public static string Serialize(List<dynamic> data)
        {
            StringBuilder output = new StringBuilder();

            foreach (var entry in data)
            {
                foreach (var item in entry)
                    output.AppendFormat("{0}{1}\n", item.Value.Export(), '}');
                output.Append("{\n");
            }
            return output.ToString();            
        }
    }
}
