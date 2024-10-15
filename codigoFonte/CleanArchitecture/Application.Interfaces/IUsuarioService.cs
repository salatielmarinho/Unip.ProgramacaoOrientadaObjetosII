namespace Application.Interfaces
{
    public interface IUsuarioService
    {
        bool InserirUsuario();

        bool AlterarUsuario();

        bool ExccluirUsuario();
    }
}