using System.ComponentModel.DataAnnotations;

namespace Test8Quali.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string? Empresa { get; set; }

        [Required]
        public string EmailPricipal { get; set; }

        public string? Email2 { get; set; }

        public string? Email3 { get; set; }

        public string? Email4 { get; set; }

        public string? TelP { get; set; }

        public string? TelC { get; set; }

        public ClienteModel(int id, string nome, string? empresa, string emailPricipal, string email2, string email3, string email4, string? telP, string? telC)
        {
            Id = id;
            Nome = nome;
            Empresa = empresa;
            EmailPricipal = emailPricipal;
            Email2 = email2;
            Email3 = email3;
            Email4 = email4;
            TelP = telP;
            TelC = telC;
        }

        public ClienteModel()
        {
        }
    }   
}
