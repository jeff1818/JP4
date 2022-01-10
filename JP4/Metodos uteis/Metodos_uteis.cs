using JP4.Config;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP4.Metodos_uteis
{
    class Metodos_uteis
    {

       //ainda não sei como fazer isso funcionar

        public string Conectar_banco_INI()
        {
            IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
            string local_default = @"C:\JP4";
            string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

            return conecta_string;

        }

    }
}
