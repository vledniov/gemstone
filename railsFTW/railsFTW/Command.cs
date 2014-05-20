using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace railsFTW
{
    class Command
    {
        public static void createProject()
        {
            create_bat_file();
        }

        private static void create_bat_file()
        {
            FileStream fs   = new FileStream("C:\\project.bat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(@"cd " + Globals.getDirectory());
            sw.WriteLine(@"rails new . --skip-bundle");
            if (Globals.getRspec())
            {
                if (Globals.getCapybara())
                {
                    sw.WriteLine(@"rake rails:template LOCATION=C:\\templates\rspec.rb FEATURE=true");
                }
                else
                {
                    sw.WriteLine(@"rake rails:template LOCATION=C:\\templates\rspec.rb");
                }
            }
            foreach (String model in Globals.getModels())
            {
                sw.WriteLine(@"rails g model" + model);
            }
            foreach (String controller in Globals.getControllers())
            {
                sw.WriteLine(@"rails g controller" + controller);
            }
            sw.Close();
            fs.Close();
        }
    }
}
