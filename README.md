# Blazor + JSONPlaceholder

Aplicação Blazor que consulta `https://jsonplaceholder.typicode.com/users` e exibe o primeiro usuário na página. Nome, cidade e empresa também são impressos no console do servidor ao acessar a página inicial.

## Executar

É necessário o .NET SDK 10.

```powershell
cd BlazorUsersJsonPlaceHolderApi
dotnet run
```

Abra o endereço informado pelo `dotnet run`. O resultado esperado no terminal é:

```text
Nome: Leanne Graham
Cidade: Gwenborough
Empresa: Romaguera-Crona
```
