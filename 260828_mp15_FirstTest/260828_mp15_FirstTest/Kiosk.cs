using System;
using System.Collections.Generic;

public class Kiosk<T> where T : Menu
{
    // 리스트에 메뉴 추가
    private List<T> list = new List<T>();
    private int count = 0;

    public void AddMenuList(T menu)
    {
        list.Add(menu);
        menu.LotNumber = count;
        Console.WriteLine($"{menu.LotNumber}{menu.Name}");
        count++;
    }
}