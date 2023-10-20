using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class EscenaManager : MonoBehaviour
{
    public void CambiarEscena()
    {
        SceneManager.LoadScene(0);
    }
}