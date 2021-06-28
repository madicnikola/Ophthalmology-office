using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer
{
	public enum Operacija
	{
		Login,
		Register,

		GetAllPacients,
		GetAllDoctors,
		GetAllExamins,

		SavePacient,
		SaveDoctor,
		SaveExamin,

		SearchPacients,
		SearchDoctors,
		SearchExamin,

		UpdatePacient,
		UpdateDoctor,
		UpdateExamin,

		DeletePacient,
		DeleteDoctor,
		DeleteExamin,

		GetAllInterventions
	}

	[Serializable]
	public class Zahtev
	{
		public Operacija Operacija { get; set; }
		public object Objekat { get; set; }

		public Zahtev()
		{
		}

		public Zahtev(Operacija operacija, object objekat)
		{
			Operacija = operacija;
			Objekat = objekat;
		}
	}
}
