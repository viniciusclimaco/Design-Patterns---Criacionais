using Builder.Builders;

namespace Builder.Directors
{
    public class Director
    {
        IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void CreateBigMac()
        {
            _builder.Reset();
            _builder.SetSandwichType(Enum.SandwichType.BigMac);
            _builder.SetBread("Pão com gergelim");
            _builder.AddIngredients(new List<string>() { "Dois hambúrgueres", "Alface americana", "Queijo cheddar", "Cebola", "Picles" });
            _builder.AddSauce(new List<string>() { "maionese Big Mac" });
            
        }

        public void CreateCheddarMcMelt()
        {
            _builder.Reset();
            _builder.SetSandwichType(Enum.SandwichType.CheddarMcMelt);
            _builder.SetBread("Pão escuro com gergelim");
            _builder.AddIngredients(new List<string>() { "Um hambúrguer", "Cebola ao molho shoyu" });
            _builder.AddSauce(new List<string>() { "Molho sabor cheddar" });

        }

        public void CreateBigTasty()
        {
            _builder.Reset();
            _builder.SetSandwichType(Enum.SandwichType.BigTasty);
            _builder.SetBread("Pão com gergelim");
            _builder.AddIngredients(new List<string>() { "Um hambúrguer", "Alface americana", "Queijo sabor emental", "Cebola", "Tomata" });
            _builder.AddSauce(new List<string>() { "molho Tasty" });

        }

        public void CreateQuarteirao()
        {
            _builder.Reset();
            _builder.SetSandwichType(Enum.SandwichType.Quarteirao);
            _builder.SetBread("Pão com gergelim");
            _builder.AddIngredients(new List<string>() { "Um hambúrguer", "Queijo cheddar", "Cebola", "Picles" });
            _builder.AddSauce(new List<string>() { "Ketchup", "Mostarda" });

        }
    }
}
