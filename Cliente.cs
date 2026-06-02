
using System.Windows.Forms;
namespace ProyectoLavanderia
{
	public class Cliente
	{
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { 
				if(value.Length >= 3)
					nombre = value; 
				else 	MessageBox.Show("El nombre debe tener al menos 3 caracteres.");
			}
		}
		private string telefono;

		public string Telefono
		{
			get { return telefono; }
			set
			{
				if (value.Length == 8)
					telefono = value;
				else
					MessageBox.Show("El teléfono debe tener 8 dígitos.");
			}
		}
		public Cliente(string nombre, string telefono)
		{
			this.Nombre = nombre;
			this.Telefono = telefono;
		}

	}
}