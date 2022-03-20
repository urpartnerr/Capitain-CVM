using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDeNiveau : MonoBehaviour
{

    private int _incrNiveau = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Félicitation, le niveau est terminé.");

            Scene sceneActuelle = SceneManager.GetActiveScene();
            string sceneNom = sceneActuelle.name;
            int lvlComplete = GameManager.Instance.PlayerData.Niveau;

            if (sceneNom == "Level1" && lvlComplete == 1)
            {
                GameManager.Instance.PlayerData.IncrNiveau(this._incrNiveau);
            }
            else if (sceneNom == "Level2" && lvlComplete == 2)
            {
                GameManager.Instance.PlayerData.IncrNiveau(this._incrNiveau);
            }
            else if (sceneNom == "Level3" && lvlComplete == 3)
            {
                print("Felicitation");
            }

            
            if (sceneNom == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (sceneNom == "Level2")
            {
                SceneManager.LoadScene("Level3");
            }
            else if (sceneNom == "Level3")
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
