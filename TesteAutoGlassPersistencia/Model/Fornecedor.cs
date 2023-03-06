using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutoGlassPersistencia.Model
{
    public class Fornecedor
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string CNPJ { get; set; }

        public List<Produto> produtos { get; set; }
    }
}
