namespace BlazorUsersJsonPlaceHolderApi.Models;

public sealed class Usuario
{
    public string Name { get; set; } = string.Empty;
    public Endereco Address { get; set; } = new();
    public Empresa Company { get; set; } = new();
}

public sealed class Endereco
{
    public string City { get; set; } = string.Empty;
}

public sealed class Empresa
{
    public string Name { get; set; } = string.Empty;
}
