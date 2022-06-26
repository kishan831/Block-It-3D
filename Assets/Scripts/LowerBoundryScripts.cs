using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerBoundryScripts : MonoBehaviour
{
    public GameObject game;

    void Start()
    {
        game.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            game.SetActive(true);
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            game.SetActive(false);
        }

    }

}
