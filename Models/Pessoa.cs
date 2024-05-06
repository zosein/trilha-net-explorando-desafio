namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(int numeroRegistro, string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        NumeroRegistro = numeroRegistro;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public int NumeroRegistro { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}