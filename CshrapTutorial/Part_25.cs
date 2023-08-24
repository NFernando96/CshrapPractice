namespace CshrapTutorial
{
    internal class Part_25
    {
        static void Main()
        {
            Dictionary<int, string> obj = new Dictionary<int, string>();
            obj.Add(1, "Naleen");
            obj.Add(2, "Shamini");
            obj.Add(3, "Fernando");
            obj.Add(4, "Piumi");

            foreach (KeyValuePair<int, string> kvp in obj)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }

        //List<t>
        //static void Main()
        //{
        //    List<string> list = new List<string>();
        //    list.Add("Honda");
        //    list.Add("BMW");
        //    list.Add("Audi");
        //    list.Add("Toyota");

        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //Hashtable 
        //static void Main()
        //{
        //    Hashtable ht = new Hashtable();
        //    ht.Add(1, "Naleen");
        //    ht.Add(2, 45);
        //    ht.Add(2.4, "Sandu");
        //    ht.Add("3", true);

        //    foreach (DictionaryEntry de in ht)
        //    {
        //        Console.WriteLine($"Key : {de.Key} | Value : {de.Value}");
        //    }

        //    Console.WriteLine(ht.ContainsValue(1));
        //    Console.WriteLine(ht.ContainsValue(45));


    }
    //ArrayList Example
    //static void Main()
    //{
    //    ArrayList arrayList = new ArrayList();
    //    arrayList.Add(1);
    //    arrayList.Add("Naleen");
    //    arrayList.Add('A');
    //    arrayList.Add(true);
    //    arrayList.Add(45.67);
    //    int[] values = { 2, 4, 6, 7, 8, 9, };
    //    string[] Cars = { "Honda", "BMW", "Audi" };

    //    arrayList.AddRange(values);
    //    //arrayList.AddRange(Cars);

    //    arrayList.Insert(1, "Index 1");
    //    arrayList.InsertRange(3, Cars);
    //    //arrayList.Remove(Cars[0]);

    //    foreach (var item in arrayList)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}
}

