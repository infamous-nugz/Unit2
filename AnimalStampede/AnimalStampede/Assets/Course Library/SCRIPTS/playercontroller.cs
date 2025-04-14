using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float horizontalinput;
    public float speed = 12.0f;
    public float xrange = 12.5f;
    public GameObject projectileprefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // player limit
        if(transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }



        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        //player movement
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);

        //shoot

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileprefab, transform.position, projectileprefab.transform.rotation);
        }
    }
}
