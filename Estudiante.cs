
using System.Windows.Forms;
namespace ProyectoLavanderia
{
	public class Estudiante : Cliente
	{
		private string carnet;

		public string Carnet
		{
			get { return carnet; }
			set
			{
				if (value.Length == 10)
				{
					carnet = value;
				}
				else
				{
					MessageBox.Show("Carnet incorrecto, debe tener 10 dígitos.");
				}
			}
		}
		public Estudiante(string nombre, string telefono, string carnet) : base(nombre, telefono)
		{
			this.Carnet = carnet;
		}
	}
}