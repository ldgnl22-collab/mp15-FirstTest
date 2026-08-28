// https://github.com/ldgnl22-collab/mp15-FirstTest

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Drink> drinkList = new();
        List<Dessert> dessertList = new();
        List<Bread> breadList = new();
        
        drinkList.Add(new Drink("Americano", 2000));
        
        // 메뉴 상속받는 것들을 리스트로 담는 클래스

        Kiosk<Menu> kiosk = new Kiosk<Menu>();
        
        kiosk.AddMenu(drinkList[0]);
    }
}