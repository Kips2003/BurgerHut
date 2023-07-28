namespace Burger{
    public class DaySpecial:Burger{
        public override string ToString()
        {
            return string.Format(
                "Your order:\n"+
                "Day Special \n"+
                "Buns, Lattuce, Pickle, Chiecken Meet, Special Sauce"
            );
        }
    }
}