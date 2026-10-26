using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANTE_2._0_DELLATORRE
{
    //classe para pegar os dados do formulario e transformar em objeto para lançar no novo formulario de recibo
    public class ClassRecibo
    {
        public string GerarTextoRecibo(
            string nome,
            string nascimento,
            bool almoco,
            bool refrig,
            bool cerveja,
            bool suco,
            int qtdAlmoco,
            int qtdRefrig,
            int qtdCerveja,
            int qtdSuco,
            string totalTexto)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendLine("--- RECIBO DO CLIENTE ---");
            msg.AppendLine();
            msg.AppendLine("Nome: " + nome);
            msg.AppendLine("Nascimento: " + nascimento);

            msg.AppendLine();
            msg.AppendLine("--- ITENS CONSUMIDOS ---");

            if (almoco)
                msg.AppendLine("Almoço - " + qtdAlmoco + " unidade(s)");

            if (refrig)
                msg.AppendLine("Refrigerante - " + qtdRefrig + " unidade(s)");

            if (cerveja)
                msg.AppendLine("Cerveja - " + qtdCerveja + " unidade(s)");

            if (suco)
                msg.AppendLine("Suco - " + qtdSuco + " unidade(s)");

            msg.AppendLine();
            msg.AppendLine(totalTexto);

            return msg.ToString();
        }
    }
}