namespace BlazorAppWebAssembly.Server.Bean
{
    public class Usuario
    {
        public static long Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Robo RobosDisponiveis { get; set; }

        public Usuario(string nome, string senha)
        {
            Id += 1;
            this.Nome = nome;
            this.Senha = senha;
        }
    }
}
