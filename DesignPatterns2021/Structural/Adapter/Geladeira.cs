using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Adapter
{
    //classe alvo
    public class Geladeira : ICaboEletrico
    {
        public string ConectarCaboEletricoAoProduto()
        {
            return "Cabo no padrão NBR 14136 conectado ao produto com sucesso!"; 
        }
    }
}
