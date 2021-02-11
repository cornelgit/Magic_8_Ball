using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Magic_8_Ball
{
    public class MainModel
    {
        static Random random = new Random();

        public int line = 0;

        public string GetMessage()
        {
            List<string> lines = System.IO.File.ReadLines(@"..\..\8ball.txt").ToList();
            line = random.Next(0, 20);
            return lines[line];
        }
    }
}
