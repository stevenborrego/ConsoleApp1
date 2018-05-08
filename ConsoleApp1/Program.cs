using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class ProgramManager 
    {
        private Provider providerDirectoryHead;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to crazy town!");
            Console.ReadKey();
        }

        ProgramManager()
        {
            providerDirectoryHead = null;
        }

        public bool LoadProviderDirectory()
        {
            return true;
        }
    }
}
