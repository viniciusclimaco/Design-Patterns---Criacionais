namespace SimpleFactory
{
    class CooffeSimpleFactory
    {
        public static Cooffe CreateCooffe(string nome)
        {
            Cooffe cooffe;
            switch (nome)
            {
                case "M":
                    cooffe = new CooffeMacchiato();
                    break;
                case "I":
                    cooffe = new CooffeIrish();
                    break;
                case "E":
                    cooffe = new CooffeExpresso();
                    break;
                case "D":
                    cooffe = new CooffeExpresso();
                    break;
                default:
                    throw new ApplicationException($"O café selecionado {nome} não existe.");
            }
            return cooffe;
        }
    }
}
