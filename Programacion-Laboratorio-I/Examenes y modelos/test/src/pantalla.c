#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include <string.h>
#include "pantalla.h"

int inicializarEstructuraPantalla(pantalla arrayStruc[],int lengArray)
{
	int i;
	int ret;
	ret = -1;
	if(arrayStruc != NULL && lengArray >0)
	{
		for (i = 0; i < lengArray; i++)
		{
			arrayStruc[i].isEmpty=1;
		}
		ret = 0;
	}
	return ret;
}//FIN inicializarEstructuraPantalla()
