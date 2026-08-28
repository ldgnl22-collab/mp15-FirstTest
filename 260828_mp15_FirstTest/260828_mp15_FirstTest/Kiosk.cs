using System;
using System.Collections.Generic;

public class Kiosk<T> where T : Menu
{
    // 리스트에 메뉴 추가
    private List<T> list = new List<T>();
    private int lotCount = 0;

    public void AddMenu(Menu menu)
    {
        menu.LotNumber = lotCount;
        Console.WriteLine($"{menu.Name}");
        lotCount++;
    }
}