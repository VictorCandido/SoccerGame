using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GolScript : MonoBehaviour
{
    public Transform Hominho1Spawner;
    public Transform Hominho2Spawner;
    public Transform TopSpawner;

    public string gol;

    public GameObject Hominho1pr;
    public GameObject Hominho2pr;
    public GameObject Toppr;

    public GameObject PlacarObject;
    private SpawnersScript Placar;

    // Start is called before the first frame update
    private void Start()
    {
        print(PlacarObject.GetComponent<SpawnersScript>());
        Placar = PlacarObject.GetComponent<SpawnersScript>();
    }

    void OnTriggerEnter2D (Collider2D obj)
    {
        if (obj.gameObject.tag == "Top")
        {
            if(gol == "1")
            {
                if (Placar.contador2 == 5)
                {
                    print("Jogador 2 Venceu!!");
                    Placar.contador1 = 0;
                    Placar.contador2 = 0;

                    SceneManager.LoadScene(3);
                }
                else
                {
                    Placar.contador2++;
                }
            }
            else
            {
                if (Placar.contador1 == 5)
                {
                    print("Jogador 1 Venceu!!");
                    Placar.contador1 = 0;
                    Placar.contador2 = 0;

                    SceneManager.LoadScene(2);
                }
                else
                {
                    Placar.contador1++;
                }
            }

            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(GameObject.FindGameObjectWithTag("Player2"));
            Destroy(GameObject.FindGameObjectWithTag("Top"));
            
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
