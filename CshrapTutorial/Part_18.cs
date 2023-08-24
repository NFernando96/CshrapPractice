namespace CshrapTutorial
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }






        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}

        //public void SetPrice(double price)
        //{
        //    if (price < 0)
        //    {
        //        throw new Exception("Price can not be a negative value");
        //    }
        //    this.price = price;
        //}

        //public double GetPrice()
        //{
        //    return this.price;
        //}
    }
    internal class Part_18
    {
        static void Main()
        {
            Product p1 = new Product();
            p1.Price = -1000;
            Console.WriteLine(p1.Price);
        }
    }
}
