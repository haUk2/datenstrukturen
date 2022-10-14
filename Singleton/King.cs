using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class King
    {

        public String name;

        private static King unserKoenig;

        private King()
        {
        }

        public static King getInstance()
        {

            if(unserKoenig == null)
            {
                unserKoenig = new King();
            }

            return unserKoenig;
        }

        public void setName(String koenig)
        {
            name = koenig;
        }

        public String Angriffsbefehl()
        {
            return name + " befiehlt: Wir greifen an!";
        }

        public String RueckzugsBefehl()
        {
            return name + " befiehlt: Wir ziehen uns zurück!";
        }



    }
}
