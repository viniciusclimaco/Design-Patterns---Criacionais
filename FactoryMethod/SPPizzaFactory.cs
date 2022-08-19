namespace FactoryMethod
{
    public class SPPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CriaPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new SPPizzaMussarela();
            }if (tipo.Equals("C"))
            {
                return new SPPizzaCalabresa();
            }
            else return null;
        }
    }
}
