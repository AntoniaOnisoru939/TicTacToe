using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doge : MonoBehaviour
{
    Transform dogeTransform;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        dogeTransform = GetComponent<Transform>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.enabled = !spriteRenderer.enabled;

       // dogeTransform.position = new Vector3(0, 1, 0);

        //dogeTransform.position = new Vector3(2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Transform dogeTransform = GetComponent<Transform>();
        //dogeTransform.position += new Vector3(0, 1, 0);
    }

    void OnMouseEnter()
    {
        //dogeTransform.position = new Vector3(2, 0, 0);
    }

    void OnMouseOver()
    {
        //dogeTransform.position += new Vector3(0, 1, 0);
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }

    void OnMouseExit()
    {
        //dogeTransform.position = new Vector3(0, 0, 0);
    }
}
