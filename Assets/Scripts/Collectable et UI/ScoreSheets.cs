using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreSheets : MonoBehaviour
{

    private TextMeshProUGUI _scoresheets;
    // Start is called before the first frame update
    void Start()
    {
        _scoresheets = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _scoresheets.text = GameManager.Instance.PlayerData.ScoreSheets.ToString();
    }
}
