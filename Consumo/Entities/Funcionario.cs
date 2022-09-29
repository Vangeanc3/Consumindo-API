using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    public class Funcionario
    {
        public int? Matricula { get; set; }
        [Required]
        public string Login { get; set; }
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public DateTime? DATAADMISSAO { get; set; }
        public DateTime? DATADEMISSAO { get; set; }
        public string? FuncaoTitular { get; set; }
        public int? FuncaoTitularCodigo { get; set; }
        public int? FuncaoSubstitutoCodigo { get; set; }
        public string? LotacaoCodigo { get; set; }
        public string? LotacaoDescricao { get; set; }
        public string? OrgaoCodigo { get; set; }
        public string? OrgaoDescricao { get; set; }
    }
}
