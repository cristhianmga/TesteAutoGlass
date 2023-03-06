using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutoGlassPersistencia.Model;

namespace TesteAutoGlassNegocio.DTO
{
    public class ProdutoDTO
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Situacao { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public FornecedorDTO? Fornecedor { get; set; }
    }
}
