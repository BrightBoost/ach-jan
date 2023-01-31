namespace GenericAndCollectionsVoorbeeld;
class Program
{
    static void Main(string[] args)
    {
        Koffie koffie = new Koffie();
        KoffieKan koffieKan = new KoffieKan(koffie);

        Limonade limonade = new Limonade("sinaasappel");
        LimonadeKan limonadeKan = new LimonadeKan(limonade);

        Kan<Koffie> kanKoffie = new Kan<Koffie>(koffie);
        Kan<Limonade> kanLimonade = new Kan<Limonade>(limonade);

        Groceries groceries = new Groceries();
        groceries.Name = "salad";

        Bag<Groceries> bag = new Bag<Groceries>(groceries);

        Groceries[] groceriesArr = { groceries };
        Bag<Groceries[]> bag1 = new Bag<Groceries[]>(groceriesArr);
        Bag<Bag<Groceries[]>> bagWithBags = new Bag<Bag<Groceries[]>>(bag1);

        UnpackBag(bag1);

        List<string> strings = new List<string>();
        strings.Add("hoii");
        Console.WriteLine(strings[0]);

        List<Koffie> koffies = new List<Koffie>();
        koffies.Add(new Koffie());
        koffies.Add(koffie);

        // lijst met adressen aanmaken
        List<Address> addresses = new List<Address>();
        addresses.Add(DummyDataAddress());
        addresses.Add(DummyDataAddress());
        addresses.Add(DummyDataAddress());


        // customer aanmaken
        Customer customer = new Customer("Marietje", addresses);

        for(int i = 0; i < customer.Addresses.Count; i++)
        {
            customer.Addresses[i].PrintAddress();
        }

        // voorbeeld dictionary
        Dictionary<string, int> namenEnLeeftijden = new Dictionary<string, int>();
        namenEnLeeftijden.Add("Martijn", 25);
        namenEnLeeftijden.Add("Sabine", 31);
        namenEnLeeftijden.Add("Joost", 30);
        namenEnLeeftijden.Add("Maaike", 31);

        int j = namenEnLeeftijden["Maaike"];
        foreach(int leeftijd in namenEnLeeftijden.Values)
        {
            Console.WriteLine(leeftijd);
        }

        foreach(string naam in namenEnLeeftijden.Keys)
        {
            Console.WriteLine(naam + " is " + namenEnLeeftijden[naam]);

        }
    }

    public static Address DummyDataAddress()
    {
        Random random = new Random();
        int nr1 = (int) random.NextInt64(0, 100);
        int nr2 = (int)random.NextInt64(0, 100);
        int nr3 = (int)random.NextInt64(0, 100);

        return new Address("Street " + nr1, nr2 + "A", "BigCity", nr3+nr2+"AC");

    }

    public static void UnpackBag(Bag<Groceries[]> b)
    {
        Groceries[] groceries = b.Inhoud;
        for(int i = 0; i < groceries.Length; i++)
        {
            Console.WriteLine(groceries[i].Name);
        }
    }


}

