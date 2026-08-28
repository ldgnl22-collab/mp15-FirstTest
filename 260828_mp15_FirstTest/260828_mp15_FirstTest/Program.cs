// https://github.com/ldgnl22-collab/mp15-FirstTest

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int selectCategory = 0;
        int selectMenu = 0;
        int menuCount = 0;

        bool openMart = true;
        
        // 메뉴 상속받는 것들을 리스트로 담는 클래스

        Kiosk kiosk = new Kiosk();
        ShoppingCart cart = new ShoppingCart();

        while (openMart)
        {
            Console.Clear();
            
            Console.WriteLine("[메뉴판]");
            kiosk.AddMenuList(new Drink("아메리카노", 2300));
            kiosk.AddMenuList(new Drink("아이스 티", 2000));
            kiosk.AddMenuList(new Drink("아이스 라떼", 2700));
            kiosk.AddMenuList(new Dessert("두쫀쿠", 3000));
            kiosk.AddMenuList(new Dessert("마들렌", 2000));
            kiosk.AddMenuList(new Bread("피자 빵", 2500));
            kiosk.AddMenuList(new Bread("모닝 빵", 1700));
            Console.WriteLine("--------------------------------------");
            
            Console.WriteLine();
            
            Console.WriteLine("1. 담기   2. 전체 비우기   3. 결제   4. 영업종료");
            selectCategory = ConsoleInput.ReadIntInRange("번호 입력 : ", 1, 4);
            selectMenu = ConsoleInput.ReadIntInRange("메뉴 선택 : ", 0, kiosk.Count-1);

            switch (selectCategory)
            {
                case 1:
                    cart.PrintShoppingList();
                    menuCount = ConsoleInput.ReadIntAtLeast("수량 : ", 0);
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    openMart = false;
                    break;
            }
            
            ConsoleInput.Pause();
            // kiosk.GetMenuList.Clear();
        }
    }
}