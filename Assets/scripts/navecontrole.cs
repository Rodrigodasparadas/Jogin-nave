using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class navecontrole : MonoBehaviour
{
    public Rigidbody2D rdb;
    float velocidade;
    public SpriteRenderer fogo1, fogo2;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        andar();
    }
    void andar()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rdb.AddRelativeForce(Vector2.up * velocidade);
            if (velocidade <= 5)
                velocidade += 0.1f;
        }
        else
        {
            if (velocidade <= 0)
                velocidade = 0;
            else
                velocidade -= 0.3f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, 0, -200) * Time.deltaTime;
        };
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, 0, 200) * Time.deltaTime;
        };
    }


}
