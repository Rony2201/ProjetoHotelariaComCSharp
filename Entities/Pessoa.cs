namespace PROJETOSCSHARP
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string  NomeCompleto => $"{Nome} {Sobrenome}";

        public string completo () {
            return NomeCompleto;
        }

    }
}
