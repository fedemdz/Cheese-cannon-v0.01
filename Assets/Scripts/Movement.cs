using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 direction = new Vector3(0f, 0f, 1f);
    public float speed = 150f;
    public float damage = 100f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale * 2;
        }
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
