#include <stdio.h>
#include <stdlib.h>
#include "publicidad.h"


int inicializarEstructuraPublicidad(publicidad arrayStruc[],int lengArray)
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
}//FIN inicializarEstructuraPublicidad()
