using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutoGlassPersistencia.Model;

namespace TesteAutoGlassNegocio.DTO
{
    public class FornecedorDTO
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string CNPJ { get; set; }

        public List<ProdutoDTO> produtos { get; set; }
    }
}
