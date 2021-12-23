using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_ASPNET.Model
{  
    [Table("PERSON")]  //BIND COM TABELA DO BANCO DE DADOS
    public class Person
    {   
        [Column("ID")] //BIND COM COLUNAS DO BANCO DE DADOS
        public long Id { get; set; }

        [Column("FIRST_NAME")]
        public string FirstName { get; set; }

        [Column("LAST_NAME")]
        public string LastName { get; set; }

        [Column("ADDRESS")]
        public string Address { get; set; }

        [Column("GENDER")]
        public string Gender { get; set; }
    }
}
