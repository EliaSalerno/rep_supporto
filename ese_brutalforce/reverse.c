#include <stdio.h>

int len(char *s)//lunghezza di un char[]
{
    int l=0;
    for(;*s;++s,++l);
    return(l);
}


int main()
{
    char alfOriginale[]="abcdefghijklmnopqrstuvwxyz ";
    char alf[]="abcdefghijklmnopqrstuvwxyz ";
    char alf2[27];
    char parola[]="hwto pztgwcftoqtghofffcrzoqpbsoxbohwtokcf so";
    for(int i=0;i<27;i++) //for per ricavare tutti le combinazioni dell'alfabeto
    {
        int l=0;
        char firstLetter=*alf;//contenuto di alf[0]
        
        for(; l<27;l++)
        {
            alf2[l]=alf[l+1];
        }   
        alf2[l-1]=firstLetter; //l-1 (la fine della stringa è sempre " ")
        for(int k=0;k<27;k++)//alf deve diventare alf2
        {
            alf[k]=alf2[k];
        }
        printf("alf= %s ",alf);
        
        int lung=len(parola);
        char risultato[lung];
        for(int k=0;k<lung;k++)//for per far girare la parola
        {
            for(int j=0;j<27;j++)//for per girare l'alfabeto
            {
                if(alf[j]==parola[k])
                //if la lettera della parola corrisponde al carattere capitato nell'alfabeto la porta ndel risultato
                risultato[k]=alfOriginale[j];//assegnazione
            }
        }
        risultato[lung]=0;
        printf("decodifica= %s\n",risultato); 
    }
}   
