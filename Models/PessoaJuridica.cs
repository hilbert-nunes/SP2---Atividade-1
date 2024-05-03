namespace Atividade
{
    class PessoaJuridica : Clientes {
        public required string Cnpj {get; set;}
        public required string ie {get; set;}

        public override void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}