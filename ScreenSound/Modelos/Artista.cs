using static System.Net.WebRequestMethods;

namespace ScreenSound.Modelos; 

public class Artista 
{
    private List<Musica> musicas = new List<Musica>();

    public Artista(string nome, string bio)
    {
        Nome = nome;
        Bio = bio;
        FotoPerfil = "https://img.freepik.com/vetores-gratis/silhueta-feminina_23-2147524227.jpg";
    }

    public string Nome { get; }
    public string FotoPerfil { get; set; }
    public string Bio { get; }
    public int Id { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Nome: {Nome}
            Foto de Perfil: {FotoPerfil}
            Bio: {Bio}";
    }
}