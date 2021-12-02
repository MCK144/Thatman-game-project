using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenSpawner : MonoBehaviour
{
    public GameObject citizen;
    const int NUM_CITIZENS = 25;

    const float GROUND_WIDTH = 200.0f;

    // Start is called before the first frame update
    void Start()
    {
        float startY = -0.5f;
        float startX;

        for (int i = 0; i < NUM_CITIZENS; i++)
        {
            //spawn the citizens
            startX = Random.Range(-GROUND_WIDTH / 4.0f, GROUND_WIDTH / 2.0f);
            Vector3 startPos = new Vector3(startX, startY, 0.0f);

            Instantiate(citizen, startPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
