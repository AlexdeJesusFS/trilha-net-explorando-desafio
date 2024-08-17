namespace DesafioProjetoHospedagem.Models
{
    public class Reserva(int diasReservados, List<Pessoa> hospedes, Suite suite)
    {
        //Campos:
        public List<Pessoa> Hospedes { get; set; } = hospedes;
        public Suite Suite { get; set; } = suite;
        public int DiasReservados { get; set; } = diasReservados;

        //Metodos:
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new Exception($"Quantidade de hóspedes é maior do que a capacidade da suite {Suite.TipoSuite}! A suite suporta somente {Suite.Capacidade} e foram selecionado {Hospedes.Count} hóspedes.");
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
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                return valor * 0.90m;//add 'm' no valor para multiplicar decimal por decimal
            }
            return valor;
        }
    }
}
