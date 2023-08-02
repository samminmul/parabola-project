using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void QuitApplication()
    {
        Debug.Log("종료되었습니다");
        Application.Quit();
    }
}
