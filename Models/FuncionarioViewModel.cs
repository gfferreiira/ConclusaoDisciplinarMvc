using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conclusao_DisciplinarMvc.Models
{
    public class FuncionarioViewModel
    {
        
        public int Id { get; set; }
        
        public string Nome { get; set; } = string.Empty;

        public FuncaoEnum Funcao { get; set; }

        public int HorasDeServico { get; set; }

    }
}