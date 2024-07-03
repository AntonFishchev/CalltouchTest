using MaterialСalculator.Interfaces;

namespace MaterialСalculator
{
	public class Countertop
	{
		public IArea Form { get; set; }

		public IMaterial Material { get; set; }

		public decimal Cost
		{
			get
			{
				return (decimal)Form.CalculateArea() * Material.Cost;
			}
		}

		public Countertop(IArea form, IMaterial material)
		{
			if (form == null)
			{
				throw new ArgumentNullException(nameof(form));
			}

			if (material == null)
			{
				throw new ArgumentNullException(nameof(material));
			}

			Form = form;
			Material = material;

		}
	}
}
