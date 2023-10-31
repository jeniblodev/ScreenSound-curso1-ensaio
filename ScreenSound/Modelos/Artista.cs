namespace ScreenSound.Modelos; 

public class Artista 
{
    private List<Musica> musicas = new List<Musica>();

    public Artista(string nome, string bio)
    {
        Nome = nome;
        Bio = bio;
    }

    public string Nome { get; }
    public string FotoPerfil { get; }
    public string Bio { get; }

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
        return $@"Nome: {Nome}
            Foto de Perfil: {FotoPerfil}
            Bio: {Bio}";
    }
}