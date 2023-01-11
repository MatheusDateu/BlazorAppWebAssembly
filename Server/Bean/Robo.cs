namespace BlazorAppWebAssembly.Server.Bean
{
    public class Robo
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }

        public Robo(string name, string description, string imageUri)
        {
            Id += 1;
            Name = name;
            Description = description;
            ImageUri = imageUri;
        }
    }
}