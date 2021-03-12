using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ExceptionHandling
{
    //Definizione di una classe per la gestione di un’eccezione
    //generata dalla mancata connessione a un database
    //filtrando il tipo per errore fatale.
    public static class DatabaseNotFound
    {
        public static void Exception()
        {
            try
            {
                ExecuteConnection();
            }
            catch (SqlException e) when (e.Class > 18) //filtro per errore fatale
            {
                //blocco di codice che gestisce l'eccezione
                Console.WriteLine("Errore Fatale");
            }
        }

        public static void ExecuteConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = .; Database=INESISTENTE; Connection Timeout = 1");
            connection.Open();
        }
    }
}
