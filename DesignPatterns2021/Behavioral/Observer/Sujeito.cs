using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Observer
{
    public abstract class Sujeito
    {
        private List<Observador> observadores = new List<Observador>();

        public void Adicionar(Observador observador)
        {
            observadores.Add(observador);
        }

        public void Remover(Observador observador)
        {
            observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var item in observadores)
            {
                item.Atualizar();
            }
        }
    }
}
