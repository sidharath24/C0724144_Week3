using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0724144
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Countryside
    {
        Village Alst = new Village();
        Village Maeland = new Village();
        Village Schenig = new Village();

    }

    class Village
    {
        Village previousVillage;
        Village NextVillage;
        String VillageName;
        bool isAstrildeHere = false;
        public Village()
        {

        }
    }

}
