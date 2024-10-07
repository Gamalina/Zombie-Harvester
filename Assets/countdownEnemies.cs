using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownEnemies : MonoBehaviour
{
    public Text countdownEnemiesText;

    // Start is called before the first frame update
    void Start()
    {
        countdownEnemiesText.GetComponent<Text>();
        countdownEnemiesText.text = string.Format(ZombieMove.enemiesKilled.ToString() + "/14", countdownEnemiesText.text);
    }

    // Update is called once per frame
    void Update()
    {
        countdownEnemiesText.text = "Enemies: " + ZombieMove.enemiesKilled.ToString() + "/14";
    }
}
