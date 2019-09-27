using System.Collections.Generic;

public class fakeDatabase
{
    public List<Category> categories;
    public List<Product> products;
    public List<Order> orders;
    public fakeDatabase()
    {
        categories = new List<Category>();
        categories.Add(new Category() { id = 1, name = "Telefon" });
        categories.Add(new Category() { id = 2, name = "Bilgisayar" });
        products = new List<Product>();
        products.Add(new Product() { id = 1, name = "iPHONE 6S", category = 1, desciription = "iPHONE 6S 32 GB AKILLI TELEFON GÜMÜŞ", imageUrl = "1.jpg", price = 2899 });
        products.Add(new Product() { id = 2, name = "XIAOMI REDMI NOTE 7", category = 1, desciription = "XIAOMI REDMI NOTE 7 128 GB AKILLI TELEFON MAVİ", imageUrl = "2.jpg", price = 2599 });
        products.Add(new Product() { id = 3, name = "SAMSUNG GALAXY A50", category = 1, desciription = "SAMSUNG GALAXY A50 64 GB AKILLI TELEFON PRİZMA BEYAZ", imageUrl = "3.jpg", price = 2800 });
        products.Add(new Product() { id = 4, name = "SAMSUNG GALAXY S10e", category = 1, desciription = "SAMSUNG GALAXY S10e 128 GB AKILLI TELEFON PRİZMA BEYAZI", imageUrl = "4.jpg", price = 4700 });
        products.Add(new Product() { id = 5, name = "HUAWEI P30 LITE", category = 1, desciription = "HUAWEI P30 LITE 128 GB AKILLI TELEFON MAVİ", imageUrl = "5.jpg", price = 3100 });
        orders = new List<Order>();


    }
}