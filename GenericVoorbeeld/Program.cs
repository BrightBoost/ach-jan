namespace GenericAndCollectionsVoorbeeld;
class Program
{
    static void Main(string[] args)
    {
        //Koffie koffie = new Koffie();
        //KoffieKan koffieKan = new KoffieKan(koffie);

        //Limonade limonade = new Limonade("sinaasappel");
        //LimonadeKan limonadeKan = new LimonadeKan(limonade);

        //Kan<Koffie> kanKoffie = new Kan<Koffie>(koffie);
        //Kan<Limonade> kanLimonade = new Kan<Limonade>(limonade);

        //Groceries groceries = new Groceries();
        //groceries.Name = "salad";

        //Bag<Groceries> bag = new Bag<Groceries>(groceries);

        //Groceries[] groceriesArr = { groceries };
        //Bag<Groceries[]> bag1 = new Bag<Groceries[]>(groceriesArr);
        //Bag<Bag<Groceries[]>> bagWithBags = new Bag<Bag<Groceries[]>>(bag1);

        //UnpackBag(bag1);

        //List<string> strings = new List<string>();
        //strings.Add("hoii");
        //Console.WriteLine(strings[0]);

        //List<Koffie> koffies = new List<Koffie>();
        //koffies.Add(new Koffie());
        //koffies.Add(koffie);

        // lijst met adressen aanmaken
        List<Address> addresses = new List<Address>();
        addresses.Add(DummyDataAddress());
        addresses.Add(DummyDataAddress());
        addresses.Add(DummyDataAddress());

        // lijst met orders aanmaken
        Product p1 = new Product("HDMI kabel");
        Dictionary<Product, int> orderItems = new Dictionary<Product, int>();
        orderItems.Add(p1, 2);
        Order o1 = new Order(orderItems);
        List<Order> orders = new List<Order>();
        orders.Add(o1);

        // customer aanmaken
        Customer customer = new Customer("Marietje", addresses, orders);

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

        // ask for input and filter for primes
        List<int> inputInts = GetListWithInts(5);
        List<int> primes = KeepPrimes(inputInts);
        Console.WriteLine(String.Join(", ", primes));

    }

    public static List<int> GetListWithInts(int nr)
    {
        Console.WriteLine("Enter " + nr + " numbers:");
        List<int> ints = new List<int>();
        for(int i = 0; i < nr; i++)
        {
            ints.Add(Convert.ToInt32(Console.ReadLine()));
        }
        return ints;
    }

    public static List<int> KeepPrimes(List<int> ints)
    {
        List<int> primes = new List<int>();
        foreach(int nr in ints)
        {
            if(IsPrime(nr))
            {
                primes.Add(nr);
            }
        }

        return primes;
    }

    public static Boolean IsPrime(int nr)
    {
        for(int i = 2; i < Math.Sqrt(nr); i++)
        {
            if(nr % i  == 0)
            {
                return false;
            }
        }
        return true;
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

