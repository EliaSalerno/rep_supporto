namespace eseprova;
public class Gatto:Cane
{
        public int AnnoNascita{get;set;}
        public override string ToString()
        {
                return string.Format($"[ChipId={ChipId},Nome={Nome},CognomeP={CognomeP},AnnoNascita={AnnoNascita}]");
        }
}
