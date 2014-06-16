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
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/k C:\\project.bat");
            procStartInfo.CreateNoWindow = false;
            procStartInfo.RedirectStandardOutput = false;
            procStartInfo.RedirectStandardError = false;
            procStartInfo.UseShellExecute = true;

            Process process = Process.Start(procStartInfo);
            process.WaitForExit();
        }

        private static void create_bat_file()
        {
            FileStream fs   = new FileStream("C:\\project.bat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(@"cd " + Globals.getDirectory());
            sw.WriteLine(@"call rails new . --skip-bundle");
            if (Globals.getRspec())
            {
                if (Globals.getCapybara())
                {
                    sw.WriteLine(@"call rake rails:template LOCATION=C:\\templates\rspec.rb FEATURE=true");
                }
                else
                {
                    sw.WriteLine(@"call rake rails:template LOCATION=C:\\templates\rspec.rb");
                }
            }
            foreach (String model in Globals.getModels())
            {
                sw.WriteLine(@"call rails generate model " + model);
            }
            sw.WriteLine(@"call rake db:migrate");
            foreach (String controller in Globals.getControllers())
            {
                sw.WriteLine(@"call rails generate controller " + controller);
            }
            sw.WriteLine(@"call rails server");
            sw.Close();
            fs.Close();
        }
    }
}
