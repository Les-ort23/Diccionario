using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_y_Cargador
{
    public class Cargador //Define la clase, en este caso "cargador"
    {
        public Dictionary<string, string> CargarURLs() //Se declara el metodo publico que retorna un diccionario, con claves de tipo string y valores de tipo string
        {
            Dictionary<string, string> DiccionarioDeUrls = new Dictionary<string, string>() //Crea e inicializa una nueva instancia de un diccionario, como el metodo utiliza valores string, en esta caso tambien tendrá claves y valores de tipo string
            {
                {"youtube","https://www.youtube.com" }, //Indica { "Clave", "Valor" } en este orden, y dependera del tipo de dato
                {"google", "https://www.google.com"},
                {"gmail", "https://mail.google.com"},
                {"facebook", "https://www.facebook.com"},
                {"twitter", "https://www.twitter.com"},
                {"instagram", "https://www.instagram.com"},
                {"linkedin", "https://www.linkedin.com"},
                {"wikipedia", "https://www.wikipedia.org"},
                {"amazon", "https://www.amazon.com"},
                {"netflix", "https://www.netflix.com"},
                {"reddit", "https://www.reddit.com"},
                {"yahoo", "https://www.yahoo.com"},
                {"bing", "https://www.bing.com"},
                {"whatsapp web", "https://web.whatsapp.com"},
                {"spotify", "https://www.spotify.com"},
                {"twitch", "https://www.twitch.tv"},
                {"pinterest", "https://www.pinterest.com"},
                {"ebay", "https://www.ebay.com"},
                {"dropbox", "https://www.dropbox.com"},
                {"tiktok", "https://www.tiktok.com"}
            };
                return DiccionarioDeUrls; //Retorna el diccionario con los datos
        }
    }
}

/*
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_y_Cargador
{
    public class Cargador //Define la clase, en este caso "cargador"
    {
        public Dictionary<string, string> CargarURLs() //Se declara el metodo publico que retorna un diccionario, con claves de tipo string y valores de tipo string
        {
            Dictionary<string, string> diccionarioDeURLs = new Dictionary<string, string>(); //Crea e inicializa una nueva instancia de un diccionario, como el metodo utiliza valores string, en esta caso tambien tendrá claves y valores de tipo string
            string teclaoprimida; // Variable utilizada para salir del Do-While

            do
            {
                Console.WriteLine("Ingresa el nombre de la página (clave): ");
                string clave = Console.ReadLine().ToLower(); //Almacena en la variable "Clave" el valor que tendra la clave del diccionario

                if (diccionarioDeURLs.ContainsKey(clave)) //Busca en el diccionario si existe la clave.
                {
                    Console.WriteLine("Esta clave ya existe. Intenta nuevamente."); //Lanza este mensaje si la clave ingresada ya existe
                    continue; //omite las instrucciones restantes en la iteración actual y pasa a la siguiente iteración del bucle.
                }

                Console.WriteLine("Ingresa la URL de la página: "); 
                string url = Console.ReadLine(); //Almacena en la variable "url" el valor asociado a la clave que tendra el diccionario

                diccionarioDeURLs.Add(clave, url); //Añade la clave (clave) y el valor (url) al diccionario

                Console.WriteLine("\n¿Desea añadir otra pagina? Pulse cualquier tecla para SI o Ingrese \"N\" para NO");
                teclaoprimida = Console.ReadLine().ToLower();
                if (teclaoprimida == "n")
                {
                    break;
                }
                            }
            while (true);

            return diccionarioDeURLs; //Retorna el diccionario con los datos
        }
    }
}
 
 
 */