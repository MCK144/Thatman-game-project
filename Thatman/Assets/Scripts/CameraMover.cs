using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    Transform cameraTrans;
    Transform playerTrans;
    // Start is called before the first frame update
    void Start()
    {
        //playerTrans = FindObjectOfType<ThatmanMover>().GetComponent<Transform>();
        cameraTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerTrans = FindObjectOfType<ThatmanMover>().GetComponent<Transform>();

        cameraTrans.position = playerTrans.position;
    }
}
