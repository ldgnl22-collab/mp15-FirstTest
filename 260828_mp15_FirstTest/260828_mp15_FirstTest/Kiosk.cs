using System;
using System.Collections.Generic;

public class Kiosk<T> where T : Menu
{
    // 리스트에 메뉴 추가
    private List<T> list = new List<T>();
    private int count = 1;

    public void AddMenuList(T menu)
    {
        list.Add(menu);
        menu.LotNumber = count;
        Console.Write($"{menu.LotNumber}. {menu.Name} ({menu.Type})  가격: {menu.Price}");
        if (menu is IDiscount)
        {
            Console.WriteLine($"  [{(menu as IDiscount).DiscountMessage()}]");
        }
        else
        {
            Console.WriteLine($"  [{menu.Discount}]");
        }
        count++;
    }
}