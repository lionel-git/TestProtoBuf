using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;

namespace TestProtoBuf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            var m = new SearchRequest();

            m.Query = "Select * from toto";
            m.PageNumber = 10;
            m.ResultPerPage = 5;
            m.Data = ByteString.CopyFrom("Hello world xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", Encoding.ASCII);
            

            Console.WriteLine("m={0}", m);

            var m2 = m;
            Console.WriteLine("m2={0}", m2);

        }
    }
}
