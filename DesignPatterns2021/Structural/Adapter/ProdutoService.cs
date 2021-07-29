using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Adapter
{
    public class ProdutoService
    {
        private readonly ICaboEletrico _caboEletrico;

        //todos os produtos tem um cabo elétrico com o conector no padrão brasileiro
        public ProdutoService(ICaboEletrico caboEletrico)
        {
            _caboEletrico = caboEletrico;
        }

        public string EnviarProduto()
        {
            return _caboEletrico.ConectarCaboEletricoAoProduto();
        }
    }
}
