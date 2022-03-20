using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonActivation : MonoBehaviour
{
    public GameObject boutonNiv1;
    public GameObject boutonNiv2;
    public GameObject boutonNiv3;

    // Start is called before the first frame update
    void Start()
    {
        
        int lvlComplete = GameManager.Instance.PlayerData.Niveau;
        boutonNiv1.SetActive(false);
        boutonNiv2.SetActive(false);
        boutonNiv3.SetActive(false);

        if (lvlComplete == 3)
        {
            boutonNiv1.SetActive(true);
            boutonNiv2.SetActive(true);
            boutonNiv3.SetActive(true);
        }
        else if (lvlComplete == 2)
        {
            boutonNiv1.SetActive(true);
            boutonNiv2.SetActive(true);
        }
        else if (lvlComplete == 1)
        {
            boutonNiv1.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
