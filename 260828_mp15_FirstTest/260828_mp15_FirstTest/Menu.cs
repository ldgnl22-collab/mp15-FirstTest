

public abstract class Menu
{
    private string name;
    private int price;
    
    public string Name { get; protected set; }
    public int Price { get; protected set; }

    public abstract void Sell();
}