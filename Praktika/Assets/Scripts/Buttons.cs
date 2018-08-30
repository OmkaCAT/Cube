using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public GameObject m_on, m_off;

    public Sprite layer_blue, layer_red;

    void Start () {
        if (gameObject.name == "Music") {
            if (PlayerPrefs.GetString("Music") == "no")
            {
                m_on.SetActive(false);
                m_off.SetActive(true);
            }
            else
            {
                m_on.SetActive(true);
                m_off.SetActive(false);
            }
        }   
    }

    void OnMouseDown () {
        GetComponent<SpriteRenderer>().sprite = layer_red;
    }

    void OnMouseUp () {
        GetComponent<SpriteRenderer>().sprite = layer_blue;
    }

    void OnMouseUpAsButton () {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click Audio").GetComponent<AudioSource>().Play();

        switch (gameObject.name) {
            case "Play":
                SceneManager.LoadScene("play", LoadSceneMode.Single);
                break;
            case "Favourite":
                //Create Rating
                break;
            case "Replay":
                SceneManager.LoadScene("play", LoadSceneMode.Single);
                break;
            case "Home":
                SceneManager.LoadScene("main", LoadSceneMode.Single);
                break;
            case "How To":
                SceneManager.LoadScene("howTo", LoadSceneMode.Single);
                break;
            case "Close":
                SceneManager.LoadScene("main", LoadSceneMode.Single);
                break;
            case "Music":
                if (PlayerPrefs.GetString("Music") != "no") {
                    PlayerPrefs.SetString("Music", "no");
                    m_on.SetActive(false);
                    m_off.SetActive(true);
                }
                else {
                    PlayerPrefs.SetString("Music", "yes");
                    m_on.SetActive(true);
                    m_off.SetActive(false);
                }  
                break;
            case "Exit":
                Application.Quit();
                break;
        }
    }
}
