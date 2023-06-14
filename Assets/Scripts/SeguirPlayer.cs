using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;

public class SeguirPlayer : MonoBehaviour
{
    public Transform alvo;
    public float moveSpeed = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(alvo);
        transform.position = Vector3.MoveTowards(transform.position, alvo.position, moveSpeed * Time.deltaTime);

    }

    

}