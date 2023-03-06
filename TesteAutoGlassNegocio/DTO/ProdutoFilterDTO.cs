﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutoGlassNegocio.DTO
{
    public class ProdutoFilterDTO
    {
        public int? Codigo { get; set; }
        public string? Descricao { get; set; }
        public bool? Situacao { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        public int? CodigoFornecedor { get; set; }
        public string? DescricaoFornecedor { get; set; }
        public string? CNPJFornecedor { get; set; }
    }
}
