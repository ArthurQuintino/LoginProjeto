using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Login.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string tipoColaborador { get; set; }
    }
}
