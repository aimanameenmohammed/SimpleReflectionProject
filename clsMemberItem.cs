using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject
{
    public class clsMemberItem
    {


        public string Name { get; set; }
        public string Type {  get; set; }
        public MemberInfo member { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {Type}";
        }

    }
}
