using Builder.Builders;
using Builder.Enum;
using Builder.Products;

namespace Builder.ConcreteBuilders
{
    class SandwichBuilder : IBuilder
    {
        private Sandwich sandwich = new Sandwich();
        public void AddIngredients(IList<string> ingredient)
        {
            sandwich.Ingredients = new List<string>();
            sandwich.Ingredients.AddRange(ingredient);
        }

        public void AddSauce(IList<string> sauce)
        {
            sandwich.Sauce = new List<string>();
            sandwich.Sauce.AddRange(sauce);
        }

        public Sandwich GetProduct()
        {
            return sandwich;
        }

        public void Reset()
        {
            sandwich = new Sandwich();
        }

        public void SetBread(string bread)
        {
            sandwich.Bread = bread;
        }

        public void SetSandwichType(SandwichType sandwichType)
        {
            sandwich.SandwichType = sandwichType;
        }
    }
}
