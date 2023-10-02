#include <stdio.h>

int main()
{
	int a,b;
	int *p,*r;
	p=&a;
	r=&b;
	printf("Inserire il primo valore: ");
	scanf("%d",p);
	printf("valore inserito %d",a);
	printf("Inserire il secondo valore: ");
	scanf("%d",r);
	printf("valore inserito %d",b);
	return 0;
}
