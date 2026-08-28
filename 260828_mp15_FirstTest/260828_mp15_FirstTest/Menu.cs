

using System;

public abstract class Menu
{
    private string name;
    private int price;
    
    public string Name { get; protected set; }
    public int Price { get; protected set; }

    public void Sell(int money)
    {
        if (money < price)
        {
            Console.WriteLine("잔액 부족");
        }
        else
        {
            Console.WriteLine("결제 완료");
        }
    }
}