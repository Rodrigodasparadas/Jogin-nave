using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    float rotation;
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        rotation = Random.Range(0, 360);
        transform.eulerAngles = new Vector3(0, 0, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }

    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
