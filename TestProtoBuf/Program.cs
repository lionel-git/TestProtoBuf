using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using System.IO;

namespace TestProtoBuf
{
    class Program
    {



        public static void PrintMessage(IMessage message)
        {
            var descriptor = message.Descriptor;
            foreach (var field in descriptor.Fields.InDeclarationOrder())
            {
                Console.WriteLine(
                    "Field {0} ({1}): {2}",
                    field.FieldNumber,
                    field.Name,
                    field.Accessor.GetValue(message));
            }
        }



        public static void PrintSmart(IMessage message)
        {
            var descriptor = message.Descriptor;

            //Clone
            var buffer = message.ToByteArray();

            // Todo; trouver fonction par reflection?
            //var z=message.GetType().GetProperty("Parser");    
            //var m0 = z.GetMethod;
           // var m = z.PropertyType.GetMethod("ParseFrom");
            //var m2 = SearchRequest.Parser.ParseFrom(buffer);

            var m2 = descriptor.Parser.ParseFrom(buffer);

            foreach (var field in descriptor.Fields.InDeclarationOrder())
            {
                if (field.FieldType==Google.Protobuf.Reflection.FieldType.Bytes)
                {
                    var d = field.Accessor.GetValue(m2);
                    field.Accessor.SetValue(m2, ByteString.CopyFrom("u", Encoding.ASCII));
                }          
            }

            Console.WriteLine("After transform: {0}", m2);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            var m = new SearchRequest();

            m.Query = "Select * from toto";
            m.PageNumber = 0;
            m.ResultPerPage = 5;
            m.Data = ByteString.CopyFrom("Hello world xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", Encoding.ASCII);
            m.Contents.Add(new subfield() { Id = 1, Content = ByteString.CopyFrom("zzzzzzzzzzzzzzzzzzzz", Encoding.ASCII) });
            m.Contents.Add(new subfield() { Id = 17, Content = ByteString.CopyFrom("zzzdgdfdferg", Encoding.ASCII) });

            Console.WriteLine("m={0}", m);

            var m2 = SearchRequest.Parser.ParseFrom(m.ToByteArray());
            Console.WriteLine("m2={0}", m2);

            foreach (var item in m2.Contents)
            {
                item.Content=ByteString.CopyFrom("aaaaaa", Encoding.ASCII);
            }
            Console.WriteLine("m2_bis={0}", m2);
            Console.WriteLine("m_bis={0}", m);

            // Reflection m2 + modif
            //PrintMessage(m2);

            PrintSmart(m);
            Console.WriteLine("m_ter={0}", m);

            var js = new JsonFormatter.Settings(true);
            var jf = new JsonFormatter(js);
            Console.WriteLine("m4={0}", jf.Format(m));

            var t = new Google.Protobuf.WellKnownTypes.Any();

            Console.WriteLine(Properties.Settings.Default.Tester);
            Properties.Settings.Default.Tester = "lionel";
            Properties.Settings.Default.Save();

            Console.WriteLine(Properties.Resources.MyString);
            
            Console.WriteLine(Properties.Resources.TextFile1);
        }
    }
}
