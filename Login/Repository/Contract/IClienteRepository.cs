using Login.Models;

namespace Login.Repository.Contract
{
    public interface IClienteRepository
    {
        // login cliente

        Cliente Login(string Email, string Senha);

        //CRUD

        void Cadastrar(Cliente cliente);

        void Atualizar(Cliente cliente);

        Cliente ObterCliente(Cliente cliente);

        Cliente BuscaCpfCliente(string CPF);

        Cliente BuscaEmailCliente(string CPF);

        void Ativar(int id);

        void Desativar(int id);

        void Excluir(int id);

        IEnumerable<Cliente> ObterTodosClientes();

        //IPagedList<Cliente> ObterTodosClientes(int? pagina, string email)
    }
}
