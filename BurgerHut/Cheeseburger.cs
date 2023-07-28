namespace Burger{
    public class Cheeseburger:Burger{
        public override string ToString()
        {
            return string.Format(
                "Your order:\n"+
                "Cheeseburger \n"+
                "Buns, Cheese, Lattuce, Pickle, Hot Sauce"
            );
        }
    }
}