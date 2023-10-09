using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ese_museo
{
    public class Personaggio
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public int FkOperaId { get; set; }
        public override string ToString()
        {
            return string.Format($"[ID = {Id}, Nome = {Nome}, FkOperaId = {FkOperaId}]"); ;
        }
    }
}
