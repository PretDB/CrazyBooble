﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(this.OnClick);
    }


    void OnClick()
    {
        SceneManager.LoadScene("offline");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("offline"));
        SceneManager.UnloadSceneAsync("1");
    }
}
