using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorMira : MonoBehaviour
{
    public Vector2 posO;
    public Rigidbody2D rb;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        posO = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = posO - rb.position;

        float angle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;


    }
}