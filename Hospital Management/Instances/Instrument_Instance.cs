using System;
namespace Hospital_Management.Instances
{
	public static class Instrument_Instance
	{
		// Note: this instrument price is inaccurate and done by guessing
		public static HashSet<Instrument> Instruments = new HashSet<Instrument>
		{
			new Instrument("Scalpel", 19.99),
			new Instrument("Forceps", 5.99),
			new Instrument("Scissors", 13.99),
			new Instrument("Electrocautery", 49.99),
			new Instrument("Nasal Speculum", 13.29),
			new Instrument("Rib Spreader", 11.49),
			new Instrument("Ligature Carrie", 14.39),
			new Instrument("Bone Clamp", 18.09),
			new Instrument("Bronchoscope", 12.99),
			new Instrument("Episiotomy Scissors", 17.99),
			new Instrument("Hemostat", 12.99),
			new Instrument("Deaver Retractor", 17.99),
			new Instrument("Army-Navy Retractor", 13.99),
			new Instrument("Circular Cutter", 19.39)
		};
		
	}
}

