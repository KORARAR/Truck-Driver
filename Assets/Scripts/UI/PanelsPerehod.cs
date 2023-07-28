using UnityEngine;

public class PanelsPerehod : MonoBehaviour
{
    [SerializeField] private GameObject[] Panels;
    private static GameObject[] PanelsS;


    public static void Spratat(int id)
    {
        PanelsS[id].SetActive(false);
    }
    
    public static void Pokazat(int id)
    {
        PanelsS[id].SetActive(true);
    }

    private void Awake()
    {
        PanelsS = new GameObject[Panels.Length];
        for(int i = 0; i < Panels.Length; i++)
        {
            PanelsS[i] = Panels[i];
        }
        Pokazat(0);
    }
}
