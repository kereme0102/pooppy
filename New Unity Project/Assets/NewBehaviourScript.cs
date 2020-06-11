using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public AudioClip[] sesDosyalari;
    public float hiz;

    public float ziplamaGucu;

    public float sağ;

    public float sol;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * hiz * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))

        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu);
        }

        if (Input.GetKeyDown(KeyCode.A))

        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * sol);
        }


        if (Input.GetKeyDown(KeyCode.D))

        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right * sağ);
        }



    }

    void OnCollisionEnter2D(Collision2D temas)

    {
        if (temas.gameObject.tag == "puan")
        {

        }
        else if (temas.gameObject.tag == "fındık")
        {
            GetComponent<AudioSource>().PlayOneShot(sesDosyalari[2], 1);
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(sesDosyalari[0], 1);

        }
    }

}


