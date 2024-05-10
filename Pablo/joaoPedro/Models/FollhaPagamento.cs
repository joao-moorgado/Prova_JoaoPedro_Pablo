namespace joaoPedro.Models;

public class FolhaPagamento {

    public FolhaPagamento() {
        Id = Guid.NewGuid().ToString();
    }

    public FolhaPagamento(int valor, int quantidade, int mes, int ano, int funcionarioId) {
        Id = Guid.NewGuid().ToString();
        Valor = valor;
        Quantidade = quantidade;
        Mes = mes;
        Ano = ano;
        FuncionarioId = funcionarioId;
        SalarioBruto = salarioBruto(valor, quantidade);
    }

    public string? Id { get; set; }
    public int Valor { get; set; }
    public int Quantidade { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public int FuncionarioId { get; set; }
    public double SalarioBruto { get; set; }

    public double salarioBruto(int valor, int quantidade) {
        return valor * quantidade;
    }

}