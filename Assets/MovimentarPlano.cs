using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentarPlano : MonoBehaviour
{
    public GameObject rb;
    public float velocidade = 5;
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Plane>();
        
    }

     void FixedUpdate()//eventos fisica
    {

    }
    // Update is called once per frame
    void Update()
    {
        
        //print(rb.Rotation.X);
        var angles = transform.rotation.eulerAngles;
        angles.z += -1 * Time.deltaTime * Input.GetAxis("Horizontal") * velocidade;
        rb.transform.rotation = Quaternion.Euler(angles);


        var angles2 = transform.rotation.eulerAngles;
        angles2.x += Time.deltaTime * Input.GetAxis("Vertical") * velocidade;
        rb.transform.rotation = Quaternion.Euler(angles2);

        //rb.transform.Rotate(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"), Space.Self);
        
    }
}
