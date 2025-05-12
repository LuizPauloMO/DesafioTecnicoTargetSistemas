using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FaturamentoDiario.Metodos
{
    public class Faturamento
    {
        public Faturamento() { }

       public List<Faturamento_Diario>? FaturamentoDiario {  get; set; }=new List<Faturamento_Diario>() { };
    
        public double MenorValorFaturamento { get { return FaturamentoDiario?.Where(p=>p.Valor>0.0).Min(p => p.Valor) ?? 0.0; } }
        public double MaiorValorFaturamento { get { return FaturamentoDiario?.Where(p => p.Valor > 0.0).Max(p => p.Valor) ?? 0.0; } }

        public double ValorFaturamentoTotal { get
            {
                double total = 0.0;
                if(FaturamentoDiario != null)
                {
                    foreach (double valor in FaturamentoDiario.Select(p => p.Valor))
                    {
                        total += valor;
                    }
                }
                return total;
            } }
        public Int32 CalculaDiasMaiorQueMediaMensal()
        {
            int qtdeDiasMaiorQueMediaMensal = 0;

            double faturamento_medio = 0.0;
            int qtde_dias_faturamento = 0;

            qtde_dias_faturamento = (FaturamentoDiario?.Where(p => p.Valor > 0.00).Count())??0;

            faturamento_medio = ValorFaturamentoTotal/qtde_dias_faturamento;

            if(FaturamentoDiario != null)
            {
                qtdeDiasMaiorQueMediaMensal = FaturamentoDiario.Where(p => p.Valor > faturamento_medio).Select(p => p.Valor).Count();
            }

            return qtdeDiasMaiorQueMediaMensal;
        }
    }
}
