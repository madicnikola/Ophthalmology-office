using System;

namespace Transfer
{
	public enum Status
	{
		OK,
		ERR
	}

	[Serializable]
	public class Odgovor
	{
		public string Poruka { get; set; }
		public object Objekat { get; set; }
		public Status Status { get; set; }

	}
}
