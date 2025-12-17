using UnityEngine;

public class CasaRuim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(12.64f, -2.41f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float Velocidade = 15f;
        transform.position -= new Vector3(Velocidade * Time.deltaTime, 0f, 0f);
    }
}
