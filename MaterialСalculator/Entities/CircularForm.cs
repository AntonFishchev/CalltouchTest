using MaterialСalculator.Interfaces;

namespace MaterialСalculator.Entities
{
	public class CircularForm : IArea
	{
		public double Diameter { get; private set; }

		public CircularForm(double diameter)
		{
			if (diameter <= 0)
			{
				throw new ArgumentException(nameof(diameter));
			}

			Diameter = diameter;
		}

		public double CalculateArea()
		{
			return (Math.PI * Math.Pow(Diameter, 2)) / 4;
		}
	}
}
