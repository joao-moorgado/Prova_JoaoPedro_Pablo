namespace joaoPedro.Models;

public class Funcionario {

    public Funcionario() {
        Id = Guid.NewGuid().ToString();
    }

    public Funcionario(string nome, string cpf) {
        Id = Guid.NewGuid().ToString();
        Nome = nome;
        CPF = cpf;
    }

    public string? Id { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    

}