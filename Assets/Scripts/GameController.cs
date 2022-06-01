using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Image damaged;
    [SerializeField] GameObject endgameUI;
    public Image Damaged { get => damaged; set => damaged = value; }
    public GameObject EndgameUI { get => endgameUI; set => endgameUI = value; }
    void Start()
    {
        endgameUI.SetActive(false);
        damaged.color = new Color(1f, 1f, 1f, 0f);
    }
}
