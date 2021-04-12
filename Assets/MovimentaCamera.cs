using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaCamera : MonoBehaviour
{
    public GameObject objetoCam;
    private Vector3 posicaoInicial;
    // Start is called before the first frame update
    void Start()
    {
         posicaoInicial = this.transform.position - objetoCam.transform.position;
    }

    // Update is called once per frame
    void LateUpdate(){
        transform.position = objetoCam.transform.position + posicaoInicial;
    }
}
