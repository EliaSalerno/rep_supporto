using eseprova;
using System.Globalization;
using System.Text;

IList<Cane> dog=new List<Cane>()
{
	new(){ChipId=1,Nome="Kitty",CognomeP="Rosario",FkVet=741},
	new(){ChipId=2,Nome="Thor",CognomeP="Fumagalli",FkVet=741},
	new(){ChipId=3,Nome="Thorky",CognomeP="Brambilla",FkVet=755},
	new(){ChipId=4,Nome="Murphy",CognomeP="Rossi",FkVet=755},
	new(){ChipId=5,Nome="Sally",CognomeP="Passoni",FkVet=755}
};

IList<Gatto> cat=new List<Gatto>()
{
	new(){ChipId=6,Nome="Martin",CognomeP="Castoro",AnnoNascita=2010,FkVet=755},
	new(){ChipId=7,Nome="Ferny",CognomeP="Passoni",AnnoNascita=2011,FkVet=741},
	new(){ChipId=8,Nome="Sissy",CognomeP="Ferro",AnnoNascita=2020,FkVet=741},
	new(){ChipId=9,Nome="Tom",CognomeP="Stefanoni",AnnoNascita=2019,FkVet=755},
	new(){ChipId=10,Nome="Jerry",CognomeP="Torre",AnnoNascita=2022,FkVet=755}
};

