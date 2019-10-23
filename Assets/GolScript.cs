using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolScript : MonoBehaviour
{
    public Transform Hominho1Spawner;
    public Transform Hominho2Spawner;
    public Transform TopSpawner;

    public GameObject Hominho1pr;
    public GameObject Hominho2pr;
    public GameObject Toppr;
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D top)
    {
        if (top.gameObject.tag == "Top")
        {
            int p1Qtd = GameObject.FindGameObjectsWithTag("Player").Length;
            for (int i = 0; i < p1Qtd; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("Player")[i]);
            }

            int p2Qtd = GameObject.FindGameObjectsWithTag("Player2").Length;
            for (int i = 0; i < p1Qtd; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("Player2")[i]);
            }

            int topQtd = GameObject.FindGameObjectsWithTag("Top").Length;
            for (int i = 0; i < p1Qtd; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("Top")[i]);
            }

            Spawner();
        }
    }

    // Update is called once per frame
    void Spawner ()
    {
        Instantiate(Hominho1pr, Hominho1Spawner.position, Hominho1Spawner.rotation);
        Instantiate(Hominho2pr, Hominho2Spawner.position, Hominho2Spawner.rotation);
        Instantiate(Toppr, TopSpawner.position, TopSpawner.rotation);
    }
}
