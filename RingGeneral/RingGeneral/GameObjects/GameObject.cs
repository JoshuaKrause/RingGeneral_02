using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingGeneral
{
    class GameObject
    {
        public string Id { get; set; }

        public virtual string Export()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("{0}={1};\n", "Id", Id);

            return output.ToString();
        }
    }


}
