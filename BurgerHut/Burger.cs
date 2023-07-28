namespace Burger{
    public class Burger{
        protected bool cheese;
        protected bool pickle;
        protected string meet;
        protected string sauce;

        public Burger():this(true,true,0,0){}

        public Burger(bool cheese, bool pickle, int num1, int num2){
            this.cheese = cheese;
            this.pickle = pickle;
            Meet meet1 = (Meet)num1;
            Sauce sauce1 = (Sauce)num2;
            meet = meet1.ToString();
            sauce = sauce1.ToString();
        }

        string Cheese;
        string Pickle;
        string Meet;
        string Sauce;

        void CheeseToString(){
            if(cheese)Cheese = ", Cheese";
            else Cheese = null;
        }

        void PickleToString(){
            if(pickle)Pickle = ", Pickle";
            else Pickle = null;
        }
         void MeetToString(){
             if(meet == "None"){
                 Meet = null;
             }
             else Meet = ", "+meet;
         }
         void SauceToString(){
             if(sauce == "None"){
                 Sauce = null;
             }
             else Sauce = ", "+sauce;
         }

        public virtual string ToString(){
            CheeseToString();
            PickleToString();
            MeetToString();
            SauceToString();
            return String.Format(
                "Your order:\n"+
                "Buns, Lattuce{0}{1}{2}{3}",
                Cheese, Pickle, Meet, Sauce
            );
        }
    }
}