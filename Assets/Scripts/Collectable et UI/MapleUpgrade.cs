﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapleUpgrade : MonoBehaviour
{
    [SerializeField]
    private int _gainPoint = 7;
    private int _incrMaple = 1;
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
                .PlayerData.IncrScoreMaple(this._incrMaple);
            GameObject.Destroy(this.gameObject);
        }
    }
}
