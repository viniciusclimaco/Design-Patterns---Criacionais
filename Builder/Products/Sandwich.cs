using Builder.Enum;

namespace Builder.Products
{
    public class Sandwich
    {
        private SandwichType sandwichType;
        private string bread;
        private List<string> ingredients;
        private List<string> sauce;

        public SandwichType SandwichType
        {
            get { return sandwichType; }
            set { sandwichType = value; }
        }

        public string Bread { get { return bread; } set { bread = value; } }

        public List<string> Ingredients
        { 
            get { return ingredients; }
            set { ingredients = value; }
        }

        public List<string> Sauce
        {
            get { return sauce; }
            set { sauce = value; }
        }
    }
}
