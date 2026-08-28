// https://github.com/ldgnl22-collab/mp15-FirstTest

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 메뉴 상속받는 것들을 리스트로 담는 클래스

        Kiosk<Menu> kiosk = new Kiosk<Menu>();
        
        kiosk.AddMenuList(new Drink("아메리카노", 2300));
        kiosk.AddMenuList(new Drink("아이스 티", 2000));
        kiosk.AddMenuList(new Drink("아이스 라떼", 2700));
        kiosk.AddMenuList(new Dessert("두쫀쿠", 3000));
        kiosk.AddMenuList(new Dessert("마들렌", 2000));
        kiosk.AddMenuList(new Bread("피자 빵", 2500));
        kiosk.AddMenuList(new Bread("모닝 빵", 1700));
        
    }
}