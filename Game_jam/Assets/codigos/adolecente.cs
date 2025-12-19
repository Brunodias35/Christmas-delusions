using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class adolecente : MonoBehaviour
{
    public static int pontos;

    [SerializeField] Text score;
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

        score.text = pontos.ToString();


        if (pontos < 0) {
            pontos = 0;
            SceneManager.LoadScene("Menu");

        }


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
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Instantiate(presente, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(carvao, transform.position, Quaternion.identity);
        }
        
        //intacia as casa random
        timeCasa += Time.deltaTime;
        if (timeCasa >= 1f)
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "municaoIni")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "CasaBoa")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }
        if (collision.gameObject.tag == "CasaRuim")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }
        if (collision.gameObject.tag == "CasaNeutra")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }
    }



}






