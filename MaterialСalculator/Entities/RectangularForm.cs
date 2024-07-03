using MaterialСalculator.Interfaces;

namespace MaterialСalculator.Entities
{
	public class RectangularForm : IArea
	{
		public double Length { get; private set; }

		public double Width { get; private set; }

		public RectangularForm(double length, double wigth)
		{
			if (length <= 0) 
			{
				throw new ArgumentException(nameof(length)); 
			}

			if (wigth <= 0)
			{
				throw new ArgumentException(nameof(wigth));
			}

			Length = length;
			Width = wigth;
		}

		public double CalculateArea()
		{
			return Length * Width;
		}
	}
}
