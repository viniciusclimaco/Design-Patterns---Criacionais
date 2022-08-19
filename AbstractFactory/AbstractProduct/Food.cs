namespace AbstractFactory.AbstractProduct
{
    public abstract class Food
    {
        public abstract string Name { get; }
        public List<string> Ingredients = new List<string>();

        public abstract void Prepare();
        public abstract void Serve();

    }
}
