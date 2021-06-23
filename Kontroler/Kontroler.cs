using System;
using System.Collections.Generic;
using Domen;
using SistemskeOperacije;
using SistemskeOperacije.UserSO;
using Transfer;

namespace KontrolerNS
{
	public class Kontroler
	{
		#region singleton
		private static Kontroler instance;

		private static object _lock = new object();
		public static Kontroler Instance
		{
			get
			{
				if (instance == null)
				{
					lock (_lock)
					{
						if (instance == null)
						{
							instance = new Kontroler();
						}
					}
				}
				return instance;
			}
		}
		#endregion

		private Kontroler()
		{
		}
		public KorisnikSistema login(KorisnikSistema user)
		{
			LoginSO so = new LoginSO();
			so.IzvrsiSO(user);
			return so.Result;
		}

		public object vratiSve(IDomenskiObjekat ido)
		{
			VratiSveSO os = new VratiSveSO();
			try
			{
				os.IzvrsiSO(ido);
				List<IDomenskiObjekat> lista = ((VratiSveSO)os).lista;
				return lista;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				throw e;
			}
		}

		public object vratiSveSlozen(IDomenskiObjekat ido)
		{
			VratiSveSlozenSO os = new VratiSveSlozenSO();
			try
			{
				os.IzvrsiSO(ido);
				List<IDomenskiObjekat> lista = ((VratiSveSlozenSO)os).lista;
				return lista;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				throw e;
			}
		}
	}

	// *** SELECT ***




	// *** INSERT ***




	// *** DELETE ***




	// *** OTHER ***                


}