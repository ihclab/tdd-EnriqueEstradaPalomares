using System;
using System.Collections.Generic;
namespace Ordenamiento
{
    public class Burbuja
    {
        public void Ordenar(int[] arr){
            for (int i = 0; i < arr.Length - 1; i++){
                for (int j = 0; j < arr.Length - 1; j++){
                    if(arr[j] > arr[j + 1]){
                    int aux = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = aux;
                    }
                }
                //en el anterior, solo recorria una vez, por eso se agrega el for de "j", este realiza el cambio, mientras que "i" continua sus iteraciones
            }
        }
    }
}
