using Builder.Enum;
using Builder.Products;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void Reset();
        void AddSauce(IList<string> sauce);
        void AddIngredients(IList<string> ingredient);
        void SetBread(string bread);
        void SetSandwichType(SandwichType sandwichType);

        Sandwich GetProduct();

    }
}
