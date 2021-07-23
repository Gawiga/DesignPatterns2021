namespace DesignPatterns2021.Creational.Builder
{
    public interface IBuilder
    {
        public void Reset();
        public void ConstruirParedes();
        public void ConstruirPortas();
        public void ConstruirJanelas();
        public void ConstruirTelhado();
    }
}