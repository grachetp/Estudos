# Curso de EF Core 3.1

Link: https://desenvolvedor.io/curso-online-introducao-entity-framework-core/

### Configuração no VS Code

Instalar extensões C#, SQL Server

Criar Projeto no Terminal

dotnet sln - {Nome da Soluçao}
dotnet console -n {nomeDoProjeto} -o {NomeDaPastadoProjeto} -f netcoreapp3.1
dotnet sln {nomeDaSolucao}.sln add {caminhoDoArquivoDoProjeto}\{arquivoProj}.csproj

*Instalar Entity no Projeto*
dotnet add CursoEFCoreCA\CursoEFCore.csproj package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.5
//
