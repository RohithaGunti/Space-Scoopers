using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jwst : MonoBehaviour
{
    private float angle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var xPos = Mathf.Sin(angle) * 150f;
        var zPos = Mathf.Cos(angle) * 150f;

        transform.localPosition = new Vector3(xPos,0f,zPos);

        angle += 0.05f * Time.deltaTime;
    }
}
