using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace railsFTW
{
    class Globals
    {
        private static String  PROJECT_DIR = "";
        private static Boolean RSPEC;
        private static Boolean CAPYBARA;

        public static void setDirectory(String dir)
        {
            PROJECT_DIR = dir;
        }

        public static String getDirectory()
        {
            return PROJECT_DIR;
        }

        public static void setRspec(Boolean val)
        {
            RSPEC = val;
        }

        public static void setCapybara(Boolean val)
        {
            CAPYBARA = val;
        }
    }
}
