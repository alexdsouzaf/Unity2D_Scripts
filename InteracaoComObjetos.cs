
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteracaoComObjetos : MonoBehaviour
{

    public Text txtInteragir;
    public GameObject Bloco;
    public PlayerMoviment PlayerMoviment;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (txtInteragir.enabled && Input.GetKeyDown(KeyCode.E))
        {
            Bloco.SetActive(!Bloco.activeSelf);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //if (PlayerMoviment.intangivel)
            //{
            //    var PlayerCollider = collision.gameObject.GetComponent<BoxCollider2D>();
            //    PlayerCollider.enabled = !PlayerCollider.enabled;
            //}
            //else
            //{
                txtInteragir.enabled = true;
                Debug.Log($"é um 2d normal?{PlayerMoviment.isNormal2D}");
                //Console.WriteLine($"é um 2d normal?{PlayerMoviment.isNormal2D}");
            //}

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            txtInteragir.enabled = false;
        }
    }

    
}
