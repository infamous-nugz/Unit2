using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delayspeed = Random.Range(20.0f, 30.0f);

    // Update is called once per frame
    void Update()
    {
        delayspeed -= 0.1f;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && delayspeed <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            delayspeed = Random.Range(20.0f, 30.0f);
        }
    }
}
