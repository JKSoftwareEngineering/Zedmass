using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        RenderSettings.ambientLight = Color.black;
        GetComponent<SaveLoad>().load();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (GameObject.Find("Player").GetComponent<PlayerStats>().health <= 0)
        {
            GetComponent<SaveLoad>().save();
            SceneManager.LoadScene("MainMap");
        }
    }
}
