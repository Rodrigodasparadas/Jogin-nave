using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class spawn : MonoBehaviour
{
    public GameObject inimigo;
    float initialPosition;
    float finalPosition;
    [SerializeField] float Size;
    float checkArea;
    [SerializeField] bool horizontal;
    [SerializeField] float intervaloInicial;
    [SerializeField] float intervalo;
    int limite;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", intervaloInicial, intervalo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {   
        if (limite <= 6)
        {
            if (horizontal == true)
            {
                initialPosition = transform.position.x - (Size / 2);
                finalPosition = transform.position.x + (Size / 2);
                checkArea = Random.Range(initialPosition, finalPosition);
                Instantiate(inimigo, new Vector3(checkArea, transform.position.y, 0), Quaternion.identity);
            }
            else
            {
                initialPosition = transform.position.y - (Size / 2);
                finalPosition = transform.position.y + (Size / 2);
                checkArea = Random.Range(initialPosition, finalPosition);
                Instantiate(inimigo, new Vector3(transform.position.x, checkArea, 0), Quaternion.identity);
            }
            limite++;
            Debug.Log("limite: " + limite);
        }

    }
}
