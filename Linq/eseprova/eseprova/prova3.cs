namespace eseprova;
public class Veterinario
{
        public string CF{get;set;}=null!;
        public string Nome{get;set;}=null!;
        public string Cognome{get;set;}=null!;
        public int CodVet{get;set;}=0;

        public override string ToString()
        {
                return string.Format($"[CF={CF},Nome={Nome},Cognome={Cognome},CodVet={CodVet}]");
        }
}
