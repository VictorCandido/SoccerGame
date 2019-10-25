using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnersScript : MonoBehaviour
{
    public int contador1;
    public int contador2;
    public Text Placar1;
    public Text Placar2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Placar1.text = contador1.ToString();    
        Placar2.text = contador2.ToString();
    }
}
