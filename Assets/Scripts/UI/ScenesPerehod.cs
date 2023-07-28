using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesPerehod : MonoBehaviour
{
    public static void Perehod(int idScene)
    {
        SceneManager.LoadScene(idScene);
    }
}
