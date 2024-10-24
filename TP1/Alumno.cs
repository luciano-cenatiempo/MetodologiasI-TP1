/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 20/9/2024
 * Hora: 12:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		private int legajo;
		private int promedio;
		
		public Alumno(string n, int d, int l, int p )
		{
			this.nombre = n;
			this.dni = d;
			this.legajo = l;
			this.promedio = p;
		}
		
		public int getLegajo(){
			return this.legajo;
		}
		
		public int getPromedio(){
			return this.promedio;
		}
		
		public override bool sosIgual(Comparable com){
			return this.promedio == ((Alumno)com).getPromedio();
		}
		public override bool sosMenor(Comparable com){
			return this.promedio < ((Alumno)com).getPromedio();
		}
		public override bool sosMayor(Comparable com){
			return this.promedio > ((Alumno)com).getPromedio();
		}
		
		public override string ToString(){
			return this.getNombre() + "- Dni: " + this.getDni().ToString()+ "- Promedio: "  + this.getPromedio().ToString() ;
		}
	}
}
