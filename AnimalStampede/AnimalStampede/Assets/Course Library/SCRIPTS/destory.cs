using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class destory : MonoBehaviour

{
    private float topbound = 50;
    private float downbound = -15;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < downbound)
        {
            Destroy(gameObject);
        }
        
        
    }
}
