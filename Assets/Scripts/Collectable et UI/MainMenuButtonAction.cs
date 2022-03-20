using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtonAction : MonoBehaviour
{
    
    /// <summary>
    /// Permet d'afficher un panel transmis en paramètre
    /// </summary>
    /// <param name="PanelAOuvrir">Panel à afficher</param>
    public void AfficherPanel(GameObject PanelAOuvrir)
    {
        PanelAOuvrir.SetActive(true);
    }

    /// <summary>
    /// Permet de ferme aussi le panel actuel
    /// </summary>
    /// <param name="PanelAFermer">Panel à fermer</param>
    public void FermerPanel(GameObject PanelAFermer)
    {
        PanelAFermer.SetActive(false);
    }

    /// <summary>
    /// Permet de charger un niveau
    /// </summary>
    /// <param name="nom">Nom du niveau à charger</param>
    public void ChargerNiveau(string nom)
    {
        int lvlComplete = GameManager.Instance.PlayerData.Niveau;
        if (nom == "Level1" && lvlComplete >= 1)
        {
            SceneManager.LoadScene(nom);
        }
        else if (nom == "Level2" && lvlComplete >= 2)
        {
            SceneManager.LoadScene(nom);
        }
        else if (nom == "Level3" && lvlComplete >= 3)
        {
            SceneManager.LoadScene(nom);
        }

    }

    /// <summary>
    /// Permet de fermer l'application
    /// </summary>
    public void Quitter()
    {
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false; //Source:https://gamedevbeginner.com/how-to-quit-the-game-in-unity/
    }
}
