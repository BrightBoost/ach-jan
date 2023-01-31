using System;
namespace OOPexercise
{
	public abstract class FourSidedShape: Shape
	{
		public virtual double SideA
		{
			get; set;
		}

        public virtual double SideB
        {
            get; set;
        }

        public virtual double SideC
        {
            get; set;
        }

        public virtual double SideD
        {
            get; set;
        }
        public FourSidedShape(string kleur) : base(kleur)
		{
		}
	}
}

