using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreMaple : MonoBehaviour
{
    private TextMeshProUGUI _scoremaple;

    // Start is called before the first frame update
    void Start()
    {
        _scoremaple = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _scoremaple.text = GameManager.Instance.PlayerData.ScoreMaple.ToString();
    }
}
