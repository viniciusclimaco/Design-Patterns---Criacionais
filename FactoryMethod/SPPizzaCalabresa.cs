namespace FactoryMethod
{
    public class SPPizzaCalabresa : Pizza
    {
        public SPPizzaCalabresa()
        {
            Nome = "Pizza de Calabresa Paulista";
            Massa = "Massa Fina";
            Molho = "Molho de tomate";
            ingredientes.Add("Queijo Parmesão");
            ingredientes.Add("Azeitonas");
        }
    }
}
