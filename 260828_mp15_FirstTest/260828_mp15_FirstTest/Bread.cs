

public class Bread : Menu, IDiscount
{
    public Bread(string name, int price)
    {
        Name = name;
        Price = price;
        Type = "빵";
        Discount = discount;
    }

    public string DiscountMessage()
    {
        Discount = "3개 이상 구매시 20% 할인";
        return Discount;
    }
}