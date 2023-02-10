using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace xmlCounter {
    class Nota {
        public int valorNota { get; set; }
        public string nomeArquivo { get; set; }

        public Nota(int valorNota, string nomeArquivo) {
            this.nomeArquivo = nomeArquivo;
            this.valorNota = valorNota;
        }
    }

    class Notas {
        private List<Nota> notas = new List<Nota>();

        public void Add(int valor, string nome) {
            notas.Add(new Nota(valor, nome));
        }

        public Nota this[int index] {
            get {
                return notas[index];
            }
            set {
                notas[index] = value;
            }
        }

        public int Count {
            get {
                return notas.Count;
            }
        }

    }
}
