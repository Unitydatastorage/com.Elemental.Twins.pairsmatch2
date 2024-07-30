using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{

    [SerializeField] int level;

    // Start is called before the first frame update
    void Start()
    {

        int current = PlayerPrefs.GetInt("current", 0);
        Button button = GetComponent<Button>();
        button.interactable = level <= current;
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Level " + (level+1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void click()
    {
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.Save();
        SceneManager.LoadScene(7);
    }
}
