using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5 : MonoBehaviour
{
    public GameObject myPrefab;

    void Start()
    {
        List<int> listaWspolrzednychX = new List<int>();
        List<int> listaWspolrzednychZ = new List<int>();
        for(int i = 0; i < 10; i++)
        {
            int x = Random.Range(1, 10);
            int z = Random.Range(1, 10);
            if(listaWspolrzednychX.Count == 0)
            {
                Instantiate(myPrefab, new Vector3(x,0,z), Quaternion.identity);
                listaWspolrzednychX.Add(x); 
                listaWspolrzednychZ.Add(z); 
            }
            else
            {
                if(sprawdzCzyWspolrzedneSiePowtarzaja(x, z, listaWspolrzednychX, listaWspolrzednychZ) == true)
                {
                    i--;
                }
                else
                {
                    Instantiate(myPrefab, new Vector3(x,0,z), Quaternion.identity);
                    listaWspolrzednychX.Add(x); 
                    listaWspolrzednychZ.Add(z); 
                }
            }          
        }      
    }
    bool sprawdzCzyWspolrzedneSiePowtarzaja(int x, int z, List<int> listaWspolrzednychX, List<int> listaWspolrzednychZ)
    {
        bool czyPowtarzaja = false;
        for(int j = 0; j < listaWspolrzednychX.Count; j++)
        {
            if(listaWspolrzednychX[j] == x && listaWspolrzednychZ[j] == z)
            {
                czyPowtarzaja = true;    
            }
        }
        return czyPowtarzaja;
    }
}
