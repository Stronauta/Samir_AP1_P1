using Samir_AP1_P1.Models;
using System.ComponentModel.DataAnnotations;

namespace Samir_AP1_P1.Models
{
	public class Aportes
	{
		[Key]
		public int AporteID { get; set; }
		[Required]
		public string Persona { get; set; }
		[Required]
		[Range(minimum: 1, maximum: 10000000, ErrorMessage = "El monto debe ser mayor a 0")]
		public decimal Monto { get; set; }
	}
}