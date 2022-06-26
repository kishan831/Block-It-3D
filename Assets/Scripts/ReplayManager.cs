using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReplayManager : MonoBehaviour
{
    public void onClickReplay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
