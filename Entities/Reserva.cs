namespace PROJETOSCSHARP;

public class Reserva
{
    public List<Pessoa> Pessoas { get; set; }   = new List<Pessoa>();
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }


    public Reserva()
    {

    }
    public Reserva(int diasReservados)
    {
        if(diasReservados <= 0)
        {
            throw new ArgumentException("O número de dias resevados deve ser maior que 0");
        }
        DiasReservados = diasReservados; 
    }
    public void CadastrarSuite(Suite suite) {
            Suite = suite;
    }
    public void CadastrarHospedes(List<Pessoa> pessoas)
    {
        if(pessoas == null)
        {
            throw new ArgumentNullException(nameof(pessoas), "A lista de pessoas não pode ser nula.");
        }
        Pessoas.AddRange(pessoas);

    }

    public int ObterQuantidadeHospedes()
    {
        return Pessoas.Count;
    }

    public decimal CalcularValorDiaria()
    {
       if (Suite == null)
            {
                throw new InvalidOperationException("A suíte deve ser cadastrada antes de calcular o valor da diária.");
            }

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10) // Ajuste para refletir o desconto aplicado após 10 dias
            {
                valor *= 0.90m;
            }
            return valor;
        }

}
