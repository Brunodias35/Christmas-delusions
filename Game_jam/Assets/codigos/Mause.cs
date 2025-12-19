using UnityEngine;
using UnityEngine.SceneManagement;
public class Mause : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] string tag;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(2f * Time.deltaTime, 0f, 0f);
        if (transform.position.x > 20)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");

        }
    }

}
