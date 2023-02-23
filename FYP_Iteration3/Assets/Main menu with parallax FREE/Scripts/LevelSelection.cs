using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    public GameObject LevelSelect_Panel;

    public void LevelSelectScreen_Open()
    {
        LevelSelect_Panel.SetActive(true);
    }
}
