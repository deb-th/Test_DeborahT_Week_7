using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    //Definizione della classe di una Custom Exception
    //per l'eccezione da lanciare in caso di un utente non trovato

    [Serializable]
    public class UserNotFoundException : Exception
    {
        //Definizione dei tre costruttori predefiniti
        //della classe Exception dalla quale gli eredita

        public UserNotFoundException() : base() { }

        public UserNotFoundException(string message) : base(message) { }

        public UserNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}
