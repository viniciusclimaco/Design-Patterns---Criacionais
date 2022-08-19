namespace FactoryMethod
{
    public class RJPizzaMussarela : Pizza
    {
        public RJPizzaMussarela()
        {
            Nome = "Pizza de Mussarela Carioca";
            Massa = "Massa Fina";
            Molho = "Molho de tomate";
            ingredientes.Add("Queijo Parmesão");            
        }
    }
}
