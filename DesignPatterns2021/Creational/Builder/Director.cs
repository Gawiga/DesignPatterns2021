namespace DesignPatterns2021.Creational.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void ConstruirCasa()
        {
            _builder.ConstruirParedes();
            _builder.ConstruirPortas();
            _builder.ConstruirJanelas();
            _builder.ConstruirTelhado();
        }

    }
}