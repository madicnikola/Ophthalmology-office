using Domen;
using SistemskeOperacije;
using SistemskeOperacije.PacijentSO;
using SistemskeOperacije.LekarSO;
using SistemskeOperacije.PregledSO;
using SistemskeOperacije.UserSO;
using System;
using System.Collections.Generic;
using SistenskeOperacije.PregledSO;
using SistenskeOperacije.LekarSO;

namespace SistenskeOperacije
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

		public object register(KorisnikSistema objekat)
		{
			RegisterSO so = new RegisterSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public object sacuvajPacijenta(Pacijent objekat)
		{
			SavePacientSO so = new SavePacientSO();
			so.IzvrsiSO(objekat);
			return so.Result;

		}

		public object sacuvajLekara(Lekar objekat)
		{
			SaveDoctorSO so = new SaveDoctorSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public object sacuvajPregled(Pregled objekat)
		{
			SaveExaminSO so = new SaveExaminSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public object obrisiPacijenta(IDomenskiObjekat objekat)
		{
			DeletePacientSO so = new DeletePacientSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public object ObrisiLekara(IDomenskiObjekat objekat)
		{
			DeleteDoctorSO so = new DeleteDoctorSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public object ObrisiPregled(IDomenskiObjekat objekat)
		{
			DeleteExaminSO so = new DeleteExaminSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public List<IDomenskiObjekat> pretraziDomenskeObjekte(IDomenskiObjekat objekat)
		{
			FilterSO so = new FilterSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public object izmeniPacijenta(Pacijent objekat)
		{
			UpdatePacientSO so = new UpdatePacientSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public object izmeniLekara(Lekar objekat)
		{
			UpdateDoctorSO so = new UpdateDoctorSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}

		public object izmeniPregled(Pregled objekat)
		{
			UpdateExaminSO so = new UpdateExaminSO();
			so.IzvrsiSO(objekat);
			return so.Result;
		}
	}

	// *** SELECT ***




	// *** INSERT ***




	// *** DELETE ***




	// *** OTHER ***                


}