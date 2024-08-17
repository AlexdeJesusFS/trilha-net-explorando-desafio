namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    //Construtor com nome
    public Pessoa(string nome)
    {
        Nome = nome;
    }

    //Construtor com nome e sobrenome
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string? Sobrenome { get; set; }
    //get: acesso somente leitura
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}