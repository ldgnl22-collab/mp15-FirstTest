

public class Bread : Menu, IDiscount
{
    public Bread(string name, int price)
    {
        Name = name;
        Price = price;
        Type = "빵";
    }

    public void Discount()
    {
        // 3개 사면 10프로 할인
    }
}