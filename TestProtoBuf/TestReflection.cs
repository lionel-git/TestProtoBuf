using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;

namespace TestProtoBuf
{
    public class TestReflection
    {
        private MyData md1;
        private MyData md2;

        public TestReflection()
        {
            md1 = new MyData();
            md1.Name = "Toto1";
            md1.Contents.Add(new Content() { Description = "D1", Value = 1 });
            md1.Contents.Add(new Content() { Description = "D4", Value = 4 });


            var j = new JsonFormatter(JsonFormatter.Settings.Default);
            var s=j.Format(md1);

            md2 = new MyData();
            md2.Name = "Toto1";
            md2.Contents.Add(new Content() { Description = "D2", Value = 1 });




        }

        public void DoCheck()
        {
          
        }
    }
}
