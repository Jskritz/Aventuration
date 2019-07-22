﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Button start;
    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(Rodando);
    }

    void Rodando()
    {
        SceneManager.LoadScene("BossSkeleton");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
