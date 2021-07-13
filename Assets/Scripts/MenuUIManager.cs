using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    public Text name;
        

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    
    }

    public void SaveName()
    {
        MemoryManager.Instance.SaveName(name.text.ToString());
    }
}
