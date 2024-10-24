/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 3/9/2024
 * Hora: 14:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			// TODO: Implement Functionality Here
			
/*			
			Pila p = new Pila();
			Cola c = new Cola();
			
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			llenar(p);
			
			
			
			llenar(c);
			informar(p);
			informar(c);
			informar(multiple);
			
*/			
/*
 // Llenar personas
			Pila p = new Pila();
			Cola c = new Cola();
			
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			llenarPersonas(p);
			
			
			
			llenarPersonas(c);
			informar(multiple);
			
*/			
// llenar Alumnos
			Pila p = new Pila();
			Cola c = new Cola();
			
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			llenarAlumnos(p);
			
			
			
			llenarAlumnos(c);
			informar(multiple);
			
			Console.ReadKey();
			
		}
		
		public static void llenar(Coleccionable col){
			Random rnd = new Random();
			
			for (int i = 0; i < 20; i++) {
				Comparable com = new Numero(rnd.Next(0,19));
				col.agregar(com);
			}
		}
		
		public static void informar(Coleccionable col){
			Console.WriteLine("Cuantos: " + col.cuantos());
			Console.WriteLine("Minimo: " + col.minimo());
			Console.WriteLine("Maximo: " + col.maximo());
			
			Console.WriteLine("Hola");
			
			// Comparar, usado solo para el numero
			/*
			Console.WriteLine("Ingrese número para comparar: ");
			string teclado =  Console.ReadLine();
			int valor = Int32.Parse(teclado);
			Numero num = new Numero(valor);
			
			if (col.contiene(num)) {
			    	Console.WriteLine("El elemento leído esta en la coleccion");
			    }else{
			    	Console.WriteLine("El elemento leído NO esta en la coleccion");
			    }
			*/
			
		}
		
		public static void llenarPersonas(Coleccionable col ){
			string[] nombre = {"Facundo", "Pedro", "Juan", "Victoria", "María", "Nicolás", "Pablo", "Jazmín"};
			int[] dni = {1111,2222,3333,4444,5555,6666,7777,8888,9999};
			
			Random rnd = new Random();
			Comparable com;
			for (int i = 0; i < 20; i++) {
				com = new Persona(nombre[rnd.Next(0,8)], dni[new Random().Next(0,9)]);
					col.agregar(com);
			}
			
		}
		
		public static void llenarAlumnos(Coleccionable col){
			string[] nombres = {"Facundo", "Pedro", "Juan", "Victoria", "María", "Nicolás", "Pablo", "Jazmín"};
			
			Random rnd = new Random();
			Comparable com;
			for (int i = 0; i < 20; i++) {
				com = new Alumno(nombres[rnd.Next(0,8)], rnd.Next(39000000,45000000), rnd.Next(1000,3000), rnd.Next(0,11));
					col.agregar(com);
			}
			
		}
		
		
	}
}