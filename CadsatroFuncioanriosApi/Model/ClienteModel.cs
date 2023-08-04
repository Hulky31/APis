using CadsatroFuncioanriosApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace CadsatroFuncioanriosApi.Model
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }

        public string Representante { get; set; }

        public bool Sexo { get; set; }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        public string Email { get; set; }

        public DateTime DataCompra { get; set; } = DateTime.Now;

        public string Numero { get; set; }

        public  ProdutosEnum Produto { get; set; }

        public int LimiteCompra { get; set; }
    }
}
