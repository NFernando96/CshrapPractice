namespace CshrapTutorial
{

    public class MyProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    internal class Part_23
    {
        public static void Main()
        {
            int[] arr = { 2, 34, 56, 12, 23, 87, 12, 34, };
            int[] arr2 = { 56, 2, 1 };
            int[] arr3 = arr.Concat(arr2).ToArray();

            foreach (int i in arr3)
            {
                Console.WriteLine(i);
            }

            MyProduct[] product =
            {
                new MyProduct {Name = "product_1", Price= 54},
                new MyProduct {Name = "product_2", Price= 23},
                new MyProduct {Name = "product_3", Price= 47},
                new MyProduct {Name = "product_4", Price= 98},
            };

            foreach (var item in product)
            {
                Console.WriteLine($"Name : {item.Name} , Price : {item.Price}");
            }






        }
    }
}
