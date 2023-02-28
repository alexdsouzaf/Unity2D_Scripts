using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CriaProjetil : MonoBehaviour
{

    public GameObject projetil;
    public GameObject disparador;
    private int disparos = 0;
    public Text txtQtdDisparos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projetil, new Vector3(disparador.transform.position.x, disparador.transform.position.y, disparador.transform.position.z),Quaternion.identity);
            disparos++;
            txtQtdDisparos.text = disparos.ToString();
            txtQtdDisparos.enabled = !txtQtdDisparos.enabled;
        }
    }
}
