using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class GerarInimigo : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        int qtd = 10;
        for (int i = 0; i < qtd; i++)
        {
            
            position = new Vector3(Random.Range(1, 40), Random.Range(1, 1), Random.Range(1, 40));
            Instantiate(prefab, position, Quaternion.Euler(0, 180,0));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
