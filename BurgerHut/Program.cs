using System;

namespace Burger{
    public class MyProgram{


        public static void Main(string[] args){
///////////////////////////////////////////////

            System.Console.WriteLine(
                "******** WELCOME TO BURGERHUT ********"
            );
            System.Console.WriteLine(
                "      press any key to continue"
            );
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
/////////////////////////////////////////////////

            System.Console.WriteLine(
                "******** Menu ********"
            );
            System.Console.WriteLine(
                "1.Hamburger \n2.Cheeseburger \n3.Day Special \n4.Special Order"    
            );
            System.Console.WriteLine();

            System.Console.WriteLine(
                "Choose your order by pressing number"
            );
            char pickedNumber = '0';;
            while(pickedNumber!='1' && pickedNumber != '2'&& pickedNumber != '3' && pickedNumber != '4'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2'&& pickedNumber != '3' && pickedNumber != '4'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
            }
            Console.Clear();
//////////////////////////////////////////////////////////////////            
            switch(pickedNumber){
                case '1':
                    Hamburger hamburger = new Hamburger();
                    System.Console.WriteLine(hamburger.ToString());
                    return;
                case '2':
                    Cheeseburger cheeseburger = new Cheeseburger();
                    System.Console.WriteLine(cheeseburger.ToString());
                    return;
                case '3':
                    DaySpecial daySpecial = new DaySpecial();
                    System.Console.WriteLine(daySpecial.ToString());
                    return;
                case '4':
                    break;
                    
            }
            pickedNumber = '0';

//////////////////////////////////////////////////
            System.Console.WriteLine("******* Building Burger *******");

            bool cheese = true;

            System.Console.WriteLine("Cheese?\n1.Yes\n2.No\n(press the number)");
            while(pickedNumber != '1' && pickedNumber != '2'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
                else{
                    if(pickedNumber == '1') cheese = true;
                    else cheese = false;
                }
            }
            Console.Clear();

/////////////////////////////////////////////////////////////
            pickedNumber = '0';
            System.Console.WriteLine("******* Building Burger *******");

            bool pickle = true;

            System.Console.WriteLine("Pickle?\n1.Yes\n2.No\n(press the number)");
            while(pickedNumber != '1' && pickedNumber != '2'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
                else{
                    if(pickedNumber == '1') pickle = true;
                    else pickle = false;
                }
            }
            Console.Clear();

//////////////////////////////////////////////////////////////////////
            pickedNumber = '0';
            int MeetInInt = -1;
            System.Console.WriteLine("******* Building Burger *******");

            System.Console.WriteLine("Which kind of Meet?\n1.Chicken\n2.Beed\n3.None\n(press the number)"); 
            while(pickedNumber != '1' && pickedNumber != '2' && pickedNumber != '3'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2' && pickedNumber != '3'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
                else{
                    MeetInInt = Convert.ToInt32(pickedNumber);
                }
            }
            Console.Clear();

/////////////////////////////////////////////////////////////////////////////////
            pickedNumber = '0';
            int SauceInInt = -1;
            System.Console.WriteLine("******* Building Burger *******");

            System.Console.WriteLine("Which kind of Sauce?\n1.Hot Sauce\n2.Sweet Sauce\n3.Special Sauce\n4.None\n(press the number)"); 
            while(pickedNumber != '1' && pickedNumber != '2' && pickedNumber != '3' && pickedNumber !='4'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2' && pickedNumber != '3' && pickedNumber != '4'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
                else{
                    SauceInInt = Convert.ToInt32(pickedNumber);
                }
            }
            Console.Clear();
////////////////////////////////////////////////////////////////////////////////////////
            Burger burger = new Burger(cheese, pickle, MeetInInt, SauceInInt);
            System.Console.WriteLine(burger.ToString());
        
        }
    }
}