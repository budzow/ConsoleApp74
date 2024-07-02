using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ConsoleApp74
{
    public class ExampleController : Controller
    {
        private static string TargetDirectory = "/path/to/target/directory/";

        public void Example(string filename)
        {
            string path = Path.Combine(TargetDirectory, filename);
            System.IO.File.Delete(path);
        }
    }
}
