using System;
using System.Data.Common;

namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO{
    public class Conexoes()
    {
        public static string dbConexao() 
            {
                return "datasource = localhost; port=3306;username=root;password=1234;database=db_expense_control";
            }
    }
}
