using UnityEngine;



public class adolecente : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    [SerializeField] GameObject presente;
    [SerializeField] GameObject carvao;
    [SerializeField] GameObject CasaBoa;
    [SerializeField] GameObject CasaRuim;
    [SerializeField] GameObject CasaNeutra;
    bool movimentoAdole = true;
    bool inimovi = true;
    float Velocidade = 10f;
    float spedUp = 7f;
    float spedBaixo = 7f;
    float spedDireita = 7f;
    float timeCasa = 0f;
    // Update is called once per frame
    void Update()
    {

        int next = Random.Range(0, 4);

        if (transform.position.y <= 4.30f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0f, spedUp * Time.deltaTime, 0f);
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(spedDireita * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(spedDireita * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0f, spedUp * Time.deltaTime, 0f);
        }

        // instancia o presente e o carvao
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(presente, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(carvao, transform.position, Quaternion.identity);
        }

        //intacia as casa random
        timeCasa += Time.deltaTime;
        if(timeCasa >= 2f)
        {
            timeCasa = 0f;
            if (next == 1)
            {
                Instantiate(CasaBoa, transform.position, Quaternion.identity);
            }
            if (next == 2)
            {
                Instantiate(CasaRuim, transform.position, Quaternion.identity);
            }
            if (next == 3)
            {
                Instantiate(CasaNeutra, transform.position, Quaternion.identity);
            }

        }
           
    }
       
    
  
}
