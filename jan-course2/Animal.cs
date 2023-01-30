using System;
namespace jan_course2
{
	public class Animal
	{

		public string kleur
		{
			get; set;
		}

		public Animal(string kleur)
		{
			this.kleur = kleur;
		}

		public virtual void Eat()
		{
			Console.WriteLine("Animal eats");
		}

		public void GreetOtherAnimal(Animal animal)
		{
			Console.WriteLine("Hoi " + animal.kleur + " dier!");
			animal.Eat();
			// animal.GreetOtherAnimal(this);
		}
	}

}

