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
    public void ShiftToCreditScreen()
    {
        SceneManager.LoadScene("2.Credit_Screen");
    }
    public void ShiftToVersionScreen()
    {
        SceneManager.LoadScene("2.Setting_Version");
    }
    public void ShiftToStoreScreen()
    {
        SceneManager.LoadScene("Store");
    }
    public void ShiftToSelectStage()
    {
        SceneManager.LoadScene("SelectStage");
    }
    public void ShiftToStageOne()
    {
        SceneManager.LoadScene("Stage_1");
    }
}
