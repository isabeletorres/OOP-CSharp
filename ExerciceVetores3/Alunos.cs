using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVetores3 {
    internal class Alunos {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString() {
            return  Nome
                   + ", "
                   + Email;
        }
    }
}
