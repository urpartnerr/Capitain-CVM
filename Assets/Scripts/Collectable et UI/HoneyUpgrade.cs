using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyUpgrade : MonoBehaviour
{
    [SerializeField]
    private int _gainPoint = 5;
    private int _incrHoney = 1;
    [SerializeField]
    private AudioClip _clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameManager.Instance.AudioManager
                .PlayClipAtPoint(_clip, this.transform.position);
            GameManager.Instance
                .PlayerData.IncrScore(this._gainPoint);
            GameManager.Instance
                .PlayerData.IncrScoreHoney(this._incrHoney);
            GameObject.Destroy(this.gameObject);
        }
    }
}
