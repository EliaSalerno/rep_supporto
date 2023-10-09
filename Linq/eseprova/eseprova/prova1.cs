namespace eseprova;
public class Cane
{
	public int ChipId{get;set;}
	public string Nome{get;set;}=null!;
	public string CognomeP{get;set;}=null!;
	public int CodVet{get;set};

	public override string ToString()
	{
		return string.Format($"[ChipId={ChipId},Nome={Nome},CognomeP={CognomeP}]");
	}
}
