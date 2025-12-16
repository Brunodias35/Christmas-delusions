using UnityEngine;

public class CasaBoa : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Velocidade = 100f;
        transform.position -= new Vector3(Velocidade * Time.deltaTime,0f,0f);
    }
}
