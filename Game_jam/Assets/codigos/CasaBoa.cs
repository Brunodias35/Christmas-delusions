using UnityEngine;

public class CasaBoa : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(12.64f, -4.38f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float Velocidade = 11f;
        transform.position -= new Vector3(Velocidade * Time.deltaTime ,0f,0f);
        if (transform.position.x <= -11.43)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "presente")
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "carvao")
        {
            Destroy(collision.gameObject);

        }
    }
}
