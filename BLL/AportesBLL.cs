using Microsoft.EntityFrameworkCore;
using Samir_AP1_P1.DAL;
using Samir_AP1_P1.Models;
using System.Linq.Expressions;


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

		public bool Eliminar(Aportes aportes)
		{
			var p = _contexto.Aportes.Find(aportes.AporteID);
			_contexto.Entry(p!).State = EntityState.Detached;
			_contexto.Entry(aportes).State = EntityState.Deleted;
			return _contexto.SaveChanges() > 0;
		}

		public bool Guardar(Aportes aportes)
		{
			if (!Existe(aportes.AporteID))
	
			{
				return this.Insectar(aportes);
			}
			else
			{
				return this.Modificar(aportes);
			}
		}

		public Aportes? Buscar(int buscarId)
		{
			return _contexto.Aportes.Where(i => i.AporteID == buscarId)
				.AsNoTracking().SingleOrDefault();
		}

		public List<Aportes> GetList(Expression<Func<Aportes, bool>> criterio)
		{
			return _contexto.Aportes.AsNoTracking()
				.Where(criterio).ToList();
		}

	}
}
