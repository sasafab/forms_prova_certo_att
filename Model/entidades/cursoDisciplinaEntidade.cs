using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entidades
{
    public class cursoDisciplinaEntidade
    {
        public long Id { get; set; }
        public long DisciplinaId { get; set; }
        public long CursoId { get; set; }
        public string Periodo { get; set; }
        public string NomeDisciplina { get; set; }
        public string NomeCurso { get; set; }


    }
}
