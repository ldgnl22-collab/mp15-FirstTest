

using System;

public abstract class Menu
{
    private int lotNumber;
    private string name;
    private int count;
    private int price;
    private string type;
    protected string discount = "정가";
    
    public int LotNumber { get; set; }
    public string Name { get; protected set; }
    public int Count { get; set; }
    public int Price { get; protected set; }
    public string Type { get; protected set; }
    public string Discount { get; protected set; }

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