using MaterialСalculator.Interfaces;

namespace MaterialСalculator.Entities
{
	public class CircularForm : IArea
	{
		public double Diameter { get; set; }

		public double CalculateArea()
		{
			return Math.PI * Math.Pow(Diameter / 2, 2);
		}
	}
}
