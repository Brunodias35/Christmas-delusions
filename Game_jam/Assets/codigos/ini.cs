using UnityEngine;

public class ini : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float direction = 1;
    [SerializeField] GameObject shoot;
    float shootTimer;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer >= 3)
        {
            shootTimer = 0;
            var position = new Vector3(transform.position.x, transform.position.y, 0f);

            Instantiate(shoot, position, Quaternion.identity);

        }



        if (transform.position.y >= 4f)
        {
            direction = -1f;
        }
        else if (transform.position.y <= 0f)
        {
            direction = 1f;
        }



        transform.position += new Vector3(0f, direction * Time.deltaTime, 0f);

    }
}

