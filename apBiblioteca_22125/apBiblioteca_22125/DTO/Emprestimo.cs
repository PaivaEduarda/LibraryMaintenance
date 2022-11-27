using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Emprestimo
    {
        int idEmprestimo,
            idLeitor,
            idLivro;

        DateTime dataEmprestimo,
                 dataEmprestimoPrevista,
                 dataDevolucaoReal;

        public int IdEmprestimo
        {
            get => idEmprestimo;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idEmprestimo = value; // armazena o valor passado no atributo de destino
            }
        }

        public int IdLeitor
        {
            get => idLeitor;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idLeitor = value; // armazena o valor passado no atributo de destino
            }
        }

        public int IdLivro
        {
            get => idLivro;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idLivro = value; // armazena o valor passado no atributo de destino
            }
        }

        public DateTime DataEmprestimo { get => dataEmprestimo; set => dataEmprestimo = value; }
        public DateTime DataEmprestimoPrevista { get => dataEmprestimoPrevista; set => dataEmprestimoPrevista = value; }
        public DateTime DataDevolucaoReal { get => dataDevolucaoReal; set => dataDevolucaoReal = value; }

        public Emprestimo(int idEmprestimo, int idLeitor, int idLivro,
                              DateTime dataEmprestimo,
                              DateTime dataEmprestimoPrevista,
                              DateTime dataDevolucaoReal)
        {
            this.IdEmprestimo = idEmprestimo;
            this.IdLeitor = idLeitor;
            this.IdLivro = idLivro;
            this.DataEmprestimo = dataEmprestimo;
            this.DataEmprestimoPrevista = dataEmprestimoPrevista;
            this.DataDevolucaoReal = dataDevolucaoReal;
        }
    }
}

