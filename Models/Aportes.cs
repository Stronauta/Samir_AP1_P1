using Samir_AP1_P1.Models;
using Samir_AP1_P1.Pages;
using System.ComponentModel.DataAnnotations;

namespace Samir_AP1_P1.Models
{
	public class Aportes
	{
		[Key]
		public int AporteID { get; set; }
		[Required]
		public DateTime Fecha { get; set; } = DateTime.Now;
		[Required(ErrorMessage = "Es obligatorio introducir el nombre de la persona")]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios.")]
		public string Persona { get; set; }
		public string? Descripcion { get; set; }
		[Required]
		[Range(minimum: 1, maximum: 10000000, ErrorMessage = "El monto debe ser mayor a 0")]
		public decimal Monto { get; set; }

	}
}