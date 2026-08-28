

public class ShoppingCart : Menu
{
    private int partPrice;
    private int totalPrice;

    private List<Menu> shoppingList = new List<Menu>();
    
    public void GetMenuList(Menu menu)
    {
        if (shoppingList.Contains(menu))
        {
            menu.Count++;
            Console.WriteLine($"{menu.Name} 수량 : {menu.Count}");
        }
        else
        {
            Console.WriteLine($"{menu.Name} 수량 : {menu.Count}");
        }
        shoppingList.Add(menu);
    }

    private void PriceCalculator()
    {
        
    }

    public void PrintShoppingList()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("[장바구니]");
        
        Console.WriteLine("내역 : ");
    }
}