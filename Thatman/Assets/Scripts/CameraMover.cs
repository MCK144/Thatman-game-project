using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    Transform cameraTrans;
    const float zOffset = -20.0f;
    const float yOffset = 2.53f;

    // Start is called before the first frame update
    void Start()
    {
        //playerTrans = FindObjectOfType<ThatmanMover>().GetComponent<Transform>();
        cameraTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = FindObjectOfType<ThatmanMover>().GetComponent<Transform>();

        Vector3 pos = new Vector3(t.position.x, t.position.y + yOffset, zOffset);

        cameraTrans.position =pos;
    }
}
