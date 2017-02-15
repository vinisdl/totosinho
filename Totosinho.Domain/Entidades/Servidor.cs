namespace Totosinho.Domain.Entidades
{
    public class Servidor : EntityBase
    {
        public string AcessToken { get; private set; }

        public void SetAcessToken(string acessToken)
        {
            AcessToken = acessToken;
        }
    }
}
