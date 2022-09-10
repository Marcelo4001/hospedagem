namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (this.Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
                Console.WriteLine($"{(hospedes.Count > 1 ? "Foram cadastrados":"Foi cadastrado")} {hospedes.Count} pessoa{(hospedes.Count > 1 ? "s":"")} em suíte com capacidade para {this.Suite.Capacidade} hospede{(this.Suite.Capacidade > 1 ? "s":"")}");
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                Hospedes = new List<Pessoa>();
                Console.WriteLine();
                Console.WriteLine("Não há vagas o suficiente. Lamentamos o transtorno!");
                Console.WriteLine();
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return this.Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if
            (Hospedes.Count > 0)
            {
                valor = this.DiasReservados * this.Suite.ValorDiaria;
                if (this.DiasReservados >= 10)
                {
                    valor = valor - (valor / 10);
                }
            }

            return valor;
        }
    }
}