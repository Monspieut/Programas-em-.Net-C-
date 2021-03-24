using System;
using System.Collections.Generic;
using Repository;
using System.Linq;

namespace Model
{
    public class LocacaoVeiculoPesado
    {
        public string Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao Locacao { set; get; }
        public int IdVeiculoPesado { set; get; }
        public VeiculoPesado VeiculoPesado { set; get; }

        public LocacaoVeiculoPesado(){

        }
        public LocacaoVeiculoPesado(
            Locacao Locacao,
            VeiculoPesado VeiculoPesado
        )
        {
            Context db = new Context ();
            this.Locacao = Locacao;
            this.IdLocacao = Locacao.Id;
            this.VeiculoPesado = VeiculoPesado;
            this.IdVeiculoPesado = VeiculoPesado.Id;

           db.LocacaoVeiculoPesados.Add(this);
           db.SaveChaens();
        }

        public static IEnumerable<LocacaoVeiculoPesado> GetVeiculosPesados(int IdLocacao)
        {
            Context.db = new Context();
            return from Veiculo in db.LocacaoVeiculoPesados where Veiculo.IdLocacao == IdLocacao select Veiculo;
        }

        public static double GetTotal(int IdLocacao)
        {
            Context db = new Context();
            return (
                from Veiculo in db.LocacaoVeiculoPesados
                where Veiculo.IdLocacao == IdLocacao
                select Veiculo.VeiculoPesado.Preco
            ).Sum();
        }

        public static int GetCount(int IdLocacao)
        {
            return GetVeiculosPesados(IdLocacao).Count();
        }

    }
}
