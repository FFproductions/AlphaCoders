using System;
using System.Collections.Generic;
using System.Text;

namespace WPTrainerAssistant.Classes
{
    class CL_Grupo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Comentario { get; set; }
        public List<CL_Turma> Lista_Turmas { get; set; }
    }
}
