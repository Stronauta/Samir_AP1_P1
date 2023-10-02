using Microsoft.EntityFrameworkCore;
using Samir_AP1_P1.DAL;
using Samir_AP1_P1.Models;

namespace Samir_AP1_P1.BLL
{
	public class AportesBLL
	{
		private Context _contexto;

		public AportesBLL(Context contexto)
		{
			_contexto = contexto;
		}

		public bool Existe(int aportesId)
		{
			return _contexto.Aportes.Any(a => a.AporteID == aportesId);
		}

		public bool Insectar(Aportes aportes)
		{
			_contexto.Aportes.Add(aportes);
			return _contexto.SaveChanges() > 0;
		}

		public bool Modificar(Aportes aportes)
		{
			_contexto.Entry(aportes).State = EntityState.Modified;
			return _contexto.SaveChanges() > 0;
		}

	}
}
