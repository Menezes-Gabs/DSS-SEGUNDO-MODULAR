using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANTE_2._0_DELLATORRE
{
    public class ClassCalculo
    {
        public decimal Total { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal TotalFinal { get; private set; }

        /*aqui ele verifica se as variaveis abaixo sao verdadeiras ou nao, se sim, adiciona na conta final*/
            public void Calcular(
            bool almoco,
            bool refrigerante,
            bool cerveja,
            bool suco,
            int qtdAlmoco,
            int qtdRefrigerante,
            int qtdCerveja,
            int qtdSuco)
            {
                Total = 0;

                if (almoco)
                    Total += 35.00m * qtdAlmoco;

                if (refrigerante)
                    Total += 12.00m * qtdRefrigerante;

                if (cerveja)
                    Total += 15.00m * qtdCerveja;

                if (suco)
                    Total += 11.50m * qtdSuco;
            }

        /*verifica se o usuario é aniversariante ou nao, se verdadeiro, valor final volta com desconto*/
        public void DescontoAniversariante(bool aniversariante)
        {
            if (aniversariante)
            {
                Desconto = Total * 0.10m;
                TotalFinal = Total - Desconto;
            }
            else
            {
                Desconto = 0;
                TotalFinal = Total;
            }
        }
    }
}