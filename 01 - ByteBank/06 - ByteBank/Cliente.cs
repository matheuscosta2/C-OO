using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___ByteBank
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string Cpf 
        { 
            get
            {
                return _cpf;
            }

            set
            {
                //Aqui escrevo minha logica de validãção CPF.
                _cpf = value;
            } 
        }
        public string Profissao { get; set; }

    }
}
