using System.Collections.Generic;

namespace Totosinho.Infra.CrossCutting.Retornos
{
    public class Retorno
    {
        private readonly List<Erro> _erros;

        public Retorno(List<Erro> erros = null)
        {
            Sucesso = erros == null;
            _erros = erros ?? new List<Erro>();
        }

        public bool Sucesso { get; set; }

        public object Erros
        {
            get { return GetErros(); }
            private set { Erros = value; }
        }

        public List<Erro> GetErros()
        {
            return _erros;
        }

        public void AddErro(int code, string message)
        {
            Sucesso = false;
            _erros.Add(new Erro(code, message));
        }

        public void AddErro(Erro erro)
        {
            Sucesso = false;
            _erros.Add(erro);
        }
    }


    public class Erro
    {
        public Erro(int codigo, string mensagem)
        {
            Codigo = codigo;
            Mensagem = mensagem;
        }

        public int Codigo { get; set; }
        public string Mensagem { get; set; }
    }
}