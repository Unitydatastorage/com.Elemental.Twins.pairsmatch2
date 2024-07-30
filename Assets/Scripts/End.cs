using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI winLabel;
    [SerializeField] TextMeshProUGUI timeLabel;
    [SerializeField] TextMeshProUGUI buttonLabel;
    int level, current, time;

    // Start is called before the first frame update
    void Start()
    {
        level = PlayerPrefs.GetInt("level", 0);
        current = PlayerPrefs.GetInt("current", 0);
        time = PlayerPrefs.GetInt("time", 0);
        if(time>0)
        {
            winLabel.text = "You win";
        } else
        {
            winLabel.text = "You lose";
        }
        timeLabel.text = "Time: " + time + "s";
        buttonLabel.text = (level < current) ? "Next" : "Retry";

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void click()
    {
        if(level<current)
        {
            PlayerPrefs.SetInt("level", level + 1);
        }  else
        {
            PlayerPrefs.SetInt("level", level);
        }
        PlayerPrefs.Save();
        SceneManager.LoadScene(7);
    }

    public void menu()
    {
        SceneManager.LoadScene(2);
    }
}
