

public class Dessert : Menu, IDiscount
{
    public Dessert(string name, int price)
    {
        Name = name;
        Price = price;
        Type = "디저트";
    }

    public void Discount()
    {
        // 2개 사면 반값
        
        
    }
}