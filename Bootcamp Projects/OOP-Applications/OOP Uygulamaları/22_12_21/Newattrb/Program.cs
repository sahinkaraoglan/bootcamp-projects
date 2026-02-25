using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Newattrb
{
    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute:System.Attribute
    {
        private string topic;
        public readonly string URL;
        public HelpAttribute(string m)
        {
            topic = m;
        }
        public string Topic
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
            }
        }
    }
    [Help("ınformation class on myClass")]
    public class MyClass
    {
        public void test()
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            Console.WriteLine(info.Name);
            for(int i=0;i<attributes.Length;i++)
            {
                Console.WriteLine(attributes[i]);
            }

            Type tp = Type.GetType("Newattrb.MyClass");

            MethodInfo[] m = tp.GetMethods();
            Console.WriteLine("--------------------------------");
            Console.WriteLine(m[0]);
        }
    }
}
