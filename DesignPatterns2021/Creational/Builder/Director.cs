namespace DesignPatterns2021.Creational.Builder
{
    public class Director
    {

        private var builder;
        public void setBuiler(IBuilder builder) {
            this.builder = builder;
        }
        
        public void CriarBonecoBatman() {

        }
    }
}