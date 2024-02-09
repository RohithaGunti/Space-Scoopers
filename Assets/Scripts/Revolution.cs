using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    private float angle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var xPos = Mathf.Sin(angle) * 100f;
        var zPos = Mathf.Cos(angle) * 100f;

        transform.localPosition = new Vector3(xPos,0f,zPos);
        transform.RotateAround(transform.position, Vector3.up, 10 * Time.deltaTime);

        angle += 0.05f * Time.deltaTime;
    }
}
