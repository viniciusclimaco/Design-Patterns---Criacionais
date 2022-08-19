namespace FactoryMethod
{
    public class RJPizzaCalabresa : Pizza
    {
        public RJPizzaCalabresa()
        {
            Nome = "Pizza de Calabresa Carioca";
            Massa = "Massa Fina";
            Molho = "Molho de tomate";
            ingredientes.Add("Queijo Parmesão");            
        }
    }
}
