using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreCard : MonoBehaviour
{
    private TextMeshProUGUI _scorecard;
    // Start is called before the first frame update
    void Start()
    {
        _scorecard = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _scorecard.text = GameManager.Instance.PlayerData.ScoreCard.ToString();
    }
}
