using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar; 
    [SerializeField]
    private GameObject manualDeIntrucoes;
    private float cronometro;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }
    // Update is called once per frame
    void Update()
    {
        //quando que eu quero gerar? TEMPO
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.manualDeIntrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
       
    }
}