using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MovimentaBolinha : MonoBehaviour{
	private Rigidbody rb;
    // Start is called before the first frame update
    public float velocidade;
    public GameObject efeito; 
    public Text textoPontos;
    public Text textoFinal;
    private int score;
    public string proximaTela;
    public string telaAtual;
    void Start(){
        rb = GetComponent<Rigidbody>();
        score = 0;
    
        textoFinal.text = "";
        //textoFinal.IsActive = false;
        textoPontos.text = textoPontos.text + score.ToString();        
    }

    // Update is called once per frame
    void FixedUpdate()//eventos fisica
    {
       // Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        //double horizontal = Input.GetAxis("Horizontal");
        //if(horizontal>0){//direita
          //  rb.
        //}else{//esquerda

        //}
        //double vertical = Input.GetAxis("Vertical");
        
        
        //rb.AddForce(move * velocidade);
       
    }

    private void OnTriggerEnter(Collider other){                                                   
       if(other.gameObject.CompareTag("item")){
            Instantiate(efeito, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            MarcaPonto();
        }
        
    }
    
    void Update()
    {
        if(rb.transform.position.y < -20.5){
            textoFinal.text = "YOU LOSE!";
            
            Invoke("finalizar",2.0f);
            
        }
       
        
    }

    void MarcaPonto(){
        score++;
        textoPontos.text = "Score: "+score.ToString();
        if(score==3){
            textoFinal.text = "YOU WIN!";
            if(proximaTela == "Fim"){
                Invoke("fim",2.0f);
            }else{
                Invoke("proximaFase",2.0f);
            }
        }
    }

    void fim(){
        textoFinal.text = "Game over!";
    }
    void proximaFase(){
          SceneManager.LoadScene(proximaTela);
    }
    void finalizar(){
                
        SceneManager.LoadScene(telaAtual);
    }
}
