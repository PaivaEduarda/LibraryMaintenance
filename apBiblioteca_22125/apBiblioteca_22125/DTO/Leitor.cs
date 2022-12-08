using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Leitor
    {
        public const int tamanhoNome = 50,
                         tamanhoTelefone = 20,
                         tamanhoEmail = 50,
                         tamanhoEndereco = 100;
        int idLeitor;
        string nomeLeitor;
        string telefoneLeitor;
        string emailLeitor;
        string enderecoLeitor;

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
        public string NomeLeitor
        {
            get => nomeLeitor;
            set
            {
                if(value.Length > tamanhoNome)
                // remove qualquer caracter além do tamanho máximo do campo
                value = value.Remove(tamanhoNome);
                // preenche codigo com zeros à esquerda até completar o tamanho mãximo
                value = value.PadRight(tamanhoNome, ' ');
                // armazena o valor passado no atributo de destino
                nomeLeitor = value;
            }
        }
        public string TelefoneLeitor
        {
            get => telefoneLeitor;
            set
            {
                if(value.Length > tamanhoTelefone)
                // remove qualquer caracter além do tamanho máximo do campo
                value = value.Remove(tamanhoTelefone);
                // preenche título com espaços à direita até completar o tamanho mãximo
                value = value.PadRight(tamanhoTelefone, ' ');
                // armazena o valor passado no atributo de destino
                telefoneLeitor = value;
            }
        }
        public string EmailLeitor
        {
            get { return emailLeitor; }
            set
            {
                if(value.Length > tamanhoEmail)
                // remove qualquer caracter além do tamanho máximo do campo
                value = value.Remove(tamanhoEmail);
                // preenche título com espaços à direita até completar o tamanho mãximo
                value = value.PadRight(tamanhoEmail, ' ');
                // armazena o valor passado no atributo de destino
                emailLeitor = value;
            }
        }
        public string EnderecoLeitor
        {
            get => enderecoLeitor;
            set
            {
                if(value.Length > tamanhoEndereco)
                // remove qualquer caracter além do tamanho máximo do campo
                value = value.Remove(tamanhoEndereco);
                // preenche título com espaços à direita até completar o tamanho mãximo
                value = value.PadRight(tamanhoEndereco, ' ');
                // armazena o valor passado no atributo de destino
                enderecoLeitor = value;
            }
        }
        public Leitor(int id, string nome, string telefone, string email, string endereco)
        {
            IdLeitor = id;
            NomeLeitor = nome;
            TelefoneLeitor = telefone;
            EmailLeitor = email;
            EnderecoLeitor = endereco;
        }
    }
}

