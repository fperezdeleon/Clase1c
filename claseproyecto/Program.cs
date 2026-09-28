using System;
using System.Collections.Generic;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Hola mundo
            Console.WriteLine("Hola, C#");

            /*
            Esto
            es
            un
            comentario
            */

            // Variables

            string myString = "Esto es una cadena de texto";
            Console.WriteLine(myString);
            myString = "Aquí cambio el valor de la cadena de texto";
            Console.WriteLine("\n" + myString + "\n");

 /*           int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5;
            //float myFloat = 6.5f;
            Console.WriteLine("\n" + myFloat + "\n");

            Console.WriteLine(myInt + myDouble + myFloat);

            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinámico";
            Console.WriteLine(myDynamic + myFloat);

            var myVar = "Mi variable de tipo inferido";
            // myVar = 6; Error
            Console.WriteLine(myVar);

            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool {myBool}");

            // Constantes

            const string MyConst = "Mi constante";
            Console.WriteLine(MyConst);
*/


 /*           // Arrays

            var myArray = new string[] { "Francisco", "Gines", "Majuelo" };
            Console.WriteLine(myArray[0]);

            myArray[2] = "36";
             Console.WriteLine(myArray[2]);
           // myArray[3] = "36";
            //Console.WriteLine(myArray[3]);

            // Diccionarios

            var myDictionary = new Dictionary<string, int>
            {
                {"Castilleja", 1},
                {"Gines", 2},
                {"Valencina", 3}
            };

            Console.WriteLine(myDictionary["Gines"]);

            // Sets

            var mySet = new HashSet<string> { "Francisco", "Gines", "Majuelo", "Majuelo" };
            Console.WriteLine("Cuantos elementos hay en el Hash?"); 
            Console.WriteLine(mySet.Count);

            Console.WriteLine("Si añado uno mas");
            mySet.Add("Bollullos");
            Console.WriteLine(mySet.Count);
            Console.WriteLine(mySet.Contains("Bollullos")); // True
            
            // Tuplas

            var myTuple = ("Francisco", "Gines", "Majuelo");
            Console.WriteLine(myTuple);
           // Console.WriteLine(myTuple.Item0); "Da error pq empieza en la posicion 1
            Console.WriteLine(myTuple.Item1);

            // Bucles
            
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

var myArray2 = new string[] { "Francisco", "Gines", "Majuelo" };

            foreach (var myItem in myArray2)
            {
                Console.WriteLine(myItem);
            }

 var myDictionary2 = new Dictionary<string, int>
            {
                {"Rojo", 1},
                {"Azul", 2},
                {"Amarillo", 3}
            };

           foreach (var myItem in myDictionary2)
            {
                Console.WriteLine(myItem);
                //Console.WriteLine(myItem.Value);   //diccionario es un par de items. Si solo quiero los valores=.value
                Console.WriteLine($"{myItem.Key}: {myItem.Value}");   //  Sin las llaves Rojo: 1                                
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

           // Control de flujo

int myInt = 11;
bool myBool = true;

            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("El valor es 11");
            }
            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine("El valor es 12");
            }
            else
            {
                Console.WriteLine("El valor no es 11 ni 12");
            }

            // Funciones

          MyFunction();    ///dentro del main
          Console.WriteLine("El resultado con retorno es: "+MyFunctionWithReturn(7));  //llamada con retorno
          
           static void MyFunction()
        {
            Console.WriteLine("Mi función dentro del main");
        }

          static int MyFunctionWithReturn(int param)
        {
            return 10 + param;
        }
           
         // Clases

           var myClass = new MyClass("Francisco");
           //myClass.myName = "Majuelo";
          Console.WriteLine(myClass.myName);
            
        }
        
//Definicion de la clase MyClass
        class MyClass
        {
            // Propiedad pública de tipo texto. get permite leer su valor y set permite cambiarlo
            public string myName { get; set; }  

    // Constructor: se ejecuta al crear un objeto con "new MyClass(...)".
    // Tiene el mismo nombre que la clase, no lleva tipo de retorno
    // y recibe un parámetro llamado myName
            public MyClass(string myName)
            {
        // this.myName es la propiedad del objeto (lado izquierdo);
        // myName a secas es el parámetro recibido (lado derecho).
        // Guardamos el valor recibido dentro del objeto
                this.myName = myName;
                
            }
        }

 */
        
    }
    
    }}