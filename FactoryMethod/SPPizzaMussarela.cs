namespace FactoryMethod
{
    public class SPPizzaMussarela : Pizza
    {
        public SPPizzaMussarela()
        {
            Nome = "Pizza de Mussarela Paulista";
            Massa = "Massa Fina";
            Molho = "Molho de tomate";
            ingredientes.Add("Queijo Parmesão");
            ingredientes.Add("Azeitonas");
        }
    }
}
