using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class User
    {
        public static void GetUser(string[] array, string name)
        {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == name)
                    {
                        Console.WriteLine("Utente trovato!");
                    }
                    else
                    {
                        //Costrutto per lanciare l'eccezione
                        throw new UserNotFoundException("L'user non è stato trovato");
                    }
                }           
            
        }

        public static void SearchUser(string name)
        {
            var array = new string[]
{
                "Carlo",
                "Maria",
                "Giorgia",
                "Alberto"
            };
            try
            {
                GetUser(array, name);
            }
            catch (UserNotFoundException e) //gestore eccezione
            {
                //blocco di codice che gestisce l'eccezione
                Console.WriteLine("L'user non è stato trovato", e);
            }
        }
    }
}
