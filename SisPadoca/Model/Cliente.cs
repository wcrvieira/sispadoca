using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SisPadoca.Model
{
    public class Cliente
    {
        public string CPF { get; set; } 
        public string Nome { get; set; }
        public string Sexo { get; set; }        
        public DateTime Data_Nasc { get; set; }        
        public string Celular { get; set; }
        public string Email { get; set; }     
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }        
    }
}
