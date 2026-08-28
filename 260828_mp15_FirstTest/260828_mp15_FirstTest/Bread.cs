

public class Bread : Menu, IDiscount
{
    public Bread(string name, int price)
    {
        Name = name;
        Price = price;
        Type = "빵";
    }

    public string DiscountMessage()
    {
        return "3개 이상 10% 할인";
    }
}