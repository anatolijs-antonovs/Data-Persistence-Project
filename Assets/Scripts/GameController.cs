using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


    public static GameController Instance;
    public string playerName;
    public GameObject nameInputField;

    private void Awake() {
        // start of new code
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update() {

    }

    public void StartGame() {
        Debug.Log("Star game pressed");
        playerName = nameInputField.GetComponent<TMP_InputField>().text;
        Debug.Log("Player name: " + playerName);
        SceneManager.LoadScene(1);
    }
}
