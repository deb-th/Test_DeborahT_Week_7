using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esecuzione della custom exception
            User.SearchUser("Carolina");

            //esecuzione dell'eccezione data dalla mancata connessione a un database
            DatabaseNotFound.Exception();

        }
    }
}
