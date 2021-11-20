using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zad1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    public List<Material> randomMaterials;
    [SerializeField] int obiektyDoWygenerowania = 0;
    // obiekt do generowania
    public GameObject block;

    void Start()
    {
        Vector3 sizeXZmax = GetComponent<MeshRenderer>().bounds.max;
        Vector3 sizeXZmin = GetComponent<MeshRenderer>().bounds.min;

        float sizeXmax = sizeXZmax.x;
        float sizeXmin = sizeXZmin.x;
        float sizeZmax = sizeXZmax.z;
        float sizeZmin = sizeXZmin.z;

        float tmpX = sizeXmax;
        float tmpZ = sizeZmax;

        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(Convert.ToInt32(sizeXmin + tmpX), Convert.ToInt32(sizeXmax + tmpX)).OrderBy(x => Guid.NewGuid()).Take(10));
        List<int> pozycje_z = new List<int>(Enumerable.Range(Convert.ToInt32(sizeZmin + tmpZ), Convert.ToInt32(sizeZmax + tmpZ)).OrderBy(x => Guid.NewGuid()).Take(10));
        
        for(int i=0; i<obiektyDoWygenerowania; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i] - tmpX, 0, pozycje_z[i] - tmpZ));
        }
        foreach(Vector3 elem in positions){
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }
    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach(Vector3 pos in positions)
        {
            GameObject newObject = Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            newObject.GetComponent<MeshRenderer>().material = this.randomMaterials[UnityEngine.Random.Range(0, randomMaterials.Count)];
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}
