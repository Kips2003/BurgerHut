namespace Burger{
    public class Burger{
        protected bool cheese;
        protected bool pickle;
        protected Meet meet;
        protected Sauce sauce;

        public Burger():this(true,true,0,0){}

        public Burger(bool cheese, bool pickle, int num1, int num2){
            this.cheese = cheese;
            this.pickle = pickle;
            meet = (Meet)num1;
            sauce = (Sauce)num2;
        }

        string? Cheese;
        string? Pickle;
        string? Meet;
        string? Sauce;

        void CheeseToString(){
            if(cheese)Cheese = "Cheese,";
            else Cheese = null;
        }

        void PickleToString(){
            if(pickle)Pickle = "Pickle,";
            else Pickle = null;
        }
        void MeetToString(){
            if(meet == (Meet)3){
                Meet = null;
            }
        }
        void SauceToString(){
            if(sauce == (Sauce)4){
                Sauce = null;
            }
        }

        public virtual string ToString(){
            CheeseToString();
            PickleToString();
            MeetToString();
            SauceToString();
            return String.Format(
                "Your order:\n"+
                "Buns, Lattuce, {0} {1} {2} {3}",
                Cheese, Pickle, Meet, Sauce
            );
        }


    }
}