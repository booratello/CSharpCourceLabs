using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    static class PersonExt
    {
        public static string Validate(this Person p)
            => (!string.IsNullOrWhiteSpace(p.Name) && p.Age != null) ? "Correct" : "Incorrect";
    }
}
