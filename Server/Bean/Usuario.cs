namespace BlazorAppWebAssembly.Server.Bean
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Robo RobosDisponiveis { get; set; }

    }
}
