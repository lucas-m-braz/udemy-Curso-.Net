using System;
using System.Collections.Generic;
using System.Text;

namespace Morte_subita_Lucas
{
    class Metodo
    {

        public static void metodo(string var)
        {
            int num;
            try
            {
                num = int.Parse(var);
            }
            catch (Exception e)
            {
                num = 0;
            }

        }
    }
}
