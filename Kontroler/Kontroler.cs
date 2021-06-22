using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;
using Domen;
using SistemskeOperacije.UserSO;

namespace KontrolerNS
{
	public class Kontroler
	{
		private static Kontroler _instance;
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

		public KorisnikSistema Login(KorisnikSistema user)
		{
			LoginSO so = new LoginSO();
			so.IzvrsiSO(user);
			Console.WriteLine(so.Result);
			return so.Result;
		}

		// *** SELECT ***




		// *** INSERT ***




		// *** DELETE ***




		// *** OTHER ***                


	}
}
