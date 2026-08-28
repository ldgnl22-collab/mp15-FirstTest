using System;
using System.Collections.Generic;

public class Kiosk : Menu
{
    // 리스트에 메뉴 추가
    private List<Menu> kioskList = new List<Menu>();
    private int count = 1;
    
    public List<Menu> GetMenuList { get { return kioskList; } }
    public Kiosk()
    {}
    public int Count { get { return kioskList.Count; } }

    public void AddMenuList(Menu menu)
    {
        kioskList.Add(menu);
        Console.Write($"{kioskList.Count}. {menu.Name} ({menu.Type})  가격: {menu.Price}");
        PrintDiscount(menu);
    }

    private void PrintDiscount(Menu menu)
    {
        if (menu is IDiscount)
        {
            Console.WriteLine($"  [{(menu as IDiscount).DiscountMessage()}]");
        }
        else
        {
            Console.WriteLine($"  [{menu.Discount}]");
        }
    }

    protected Menu GetMenu(int index)
    {
        return kioskList[index];
    }
}