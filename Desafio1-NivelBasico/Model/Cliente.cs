using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1_NivelBasico.Model
{
   public  class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Cpf{ get; set; }
        public int Telefone { get; set; }
        public int Email { get; set; }
        public Endereço Endereço{ get; set; }

    }
}
