using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreChest : MonoBehaviour
{

    private TextMeshProUGUI _scorechest;
    // Start is called before the first frame update
    void Start()
    {
        _scorechest = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _scorechest.text = GameManager.Instance.PlayerData.ScoreChest.ToString();
    }
}
