using System;
namespace OOPexercise
{
	public class Square: FourSidedShape
	{

        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _sideD;

        public override double SideA
        {
            get => _sideA;
            set => AlterSidesSquare(value);
            
        }

        public override double SideB
        {
            get => _sideB;
            set => AlterSidesSquare(value);
        }

        public override double SideC
        {
            get => _sideC;                
            set => AlterSidesSquare(value);
        }

        public override double SideD
        {
            get => _sideD;
            set => AlterSidesSquare(value);
        }
        public Square(string kleur, double side): base(kleur)
		{
            SideA = side;
		}

        public override double CalcCircumference()
        {
            Circumference = 4 * SideA;
            return Circumference;
        }

        public override double CalcSurface()
        {
            Surface = SideA * SideA;
            return Surface;
        }

        public void AlterSidesSquare(double side)
        {
            _sideA = side;
            _sideB = side;
            _sideC = side;
            _sideD = side;
            CalcSurface();
            CalcCircumference();
        }
    }
}

