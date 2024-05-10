using System.ComponentModel.DataAnnotations;
using joaoPedro.Models;
using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Cadastrar Funcionario
app.MapPost("/api/funcionario/cadastrar", async ([FromBody] Funcionario funcionario, 
[FromServices] AppDbContext ctx) => {
    ctx.Funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);});


// Listar funcionarios
app.MapGet("api/funcionario/listar",
    ([FromServices] AppDbContext ctx) =>
{
    if (ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound("Tabela vazia!");
});

// Cadastrar folha de pagamento
app.MapPost("/api/folha/cadastrar", async ([FromBody] FolhaPagamento folhaPagamento, 
[FromServices] AppDbContext ctx) => {
    ctx.FolhasPagamento.Add(folhaPagamento);
    ctx.SaveChanges();
    return Results.Created("", folhaPagamento);});

// Listar folhas de pagamento
app.MapGet("api/folha/listar",
    ([FromServices] AppDbContext ctx) =>
{
    if (ctx.FolhasPagamento.Any())
    {
        return Results.Ok(ctx.FolhasPagamento.ToList());
    }
    return Results.NotFound("Tabela vazia!");
});

app.Run();
