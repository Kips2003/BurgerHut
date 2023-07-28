namespace Burger{
    public class Hamburger:Burger{
        public override string ToString()
        {
            return string.Format(
                "Your order:\n"+
                "Hamburger \n"+
                "Buns, Lattuce, Pickle, Beef Meet, Sweet Sauce"
            );
        }
    }
}