using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_y_Cargador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cargador cargadorcito = new Cargador(); //Se crea una instancia de la clase "Cargador" y se crea un objeto "Cargadorcito"
            Dictionary<string, string> diccionario = cargadorcito.CargarURLs(); //Llama al metodo "CargarURLs" a travez del objeto "cargadorcito" y almacena el diccionario retornado en la variable diccionario

            Console.WriteLine("Lista de las URLs:\n");
            foreach (var entry in diccionario) //iterar sobre todos los elementos de una colección, en este caso recorre todo el diccionario con las URLs
            {
                Console.WriteLine(entry.Key);
                //Console.WriteLine($"Nombre:{entry.Key},URL: {entry.Value}"); //Imprime en pantalla la clave y el valor del elemto del diccionario que se este recorriendo
            } //"entry" representa el elemento actual del diccionario, "Key" representa la clave (Pagina) y "Value" el "valor(URL)" 

            string URLBuscada; //Variable que almacenara el nombre de la pagina que se desea conocer la URL
            string teclaoprimida; // Variable utilizada para salir del Do-While


            do { //Ciclo Do-While en caso de que se desee buscar mas de una pagina
                Console.WriteLine("\nIngresa el nombre de la pagina que deseas conocer su URL");
                URLBuscada = Console.ReadLine().ToLower(); //ToLower convierte el texto ingresado a minusculas
                if (diccionario.ContainsKey(URLBuscada))//Busca en el diccionario la pagina ingresada por el usuario a traves de ContainsKey que es un método del Dictionary que se utiliza para verificar si el diccionario contiene una clave específica.
                {
                    Console.WriteLine($"La URL de {URLBuscada} es {diccionario[URLBuscada]}");//si se encuentra la pagina imprime el Valor (URL) asociado a la clave que contenga "URLBuscada"
                }
                else
                {
                    Console.WriteLine($"{URLBuscada} no se encuentra en el diccionario"); // indica que no se encuenta la clave "URLBuscada" en el diccionario
                }
                
                
                Console.WriteLine("\n¿Desea buscar otra pagina? Pulse cualquier tecla para SI o Ingrese \"N\" para NO");
                teclaoprimida = Console.ReadLine().ToLower();
                if (teclaoprimida == "n")
                {
                    Console.WriteLine("Programa terminado, hasta pronto.");
                    break;
                }
                
            }while (true);
            Console.ReadKey();
        }
    }
}
