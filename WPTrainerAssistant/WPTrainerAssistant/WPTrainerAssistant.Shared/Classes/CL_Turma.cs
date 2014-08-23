using System;
using System.Collections.Generic;
using System.Text;
using Windows.Data.Xml.Dom;

namespace WPTrainerAssistant.Classes
{
    class CL_Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Comentario { get; set; }
        public List<CL_Aluno> Lista_Alunos { get; set; }

    }
}
