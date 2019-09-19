using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShiftScenes : MonoBehaviour {

    public void ShiftToIntro()
    {
        SceneManager.LoadScene("intro");
    }
    public void ShiftToMainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
    public void ShiftToSettingSound()
    {
        SceneManager.LoadScene("1.Setting_Sound");
    }
    public void ShiftToSettingScreen()
    {
        SceneManager.LoadScene("2.Setting_Screen");
    }
}
