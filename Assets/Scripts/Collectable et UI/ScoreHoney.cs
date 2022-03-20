using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreHoney : MonoBehaviour
{

    private TextMeshProUGUI _scorehoney;

    // Start is called before the first frame update
    void Start()
    {
        _scorehoney = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _scorehoney.text = GameManager.Instance.PlayerData.ScoreHoney.ToString();
    }
}
