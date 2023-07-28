using UnityEngine;

public class VibraniLVL : MonoBehaviour
{
    public static int ViborLVL;

    public static void Save(int IdLVL)
    {
        ViborLVL = IdLVL;
        PlayerPrefs.SetInt("ViborLVL" ,ViborLVL);
    }

    private void Awake()
    {
        if(!PlayerPrefs.HasKey("ViborLVL")) { return; }

        ViborLVL = PlayerPrefs.GetInt("ViborLVL", ViborLVL);
    }

    public void NextLVL()
    {
        Save(ViborLVL + 1);
        ScenesPerehod.Perehod(1);
    }
}
