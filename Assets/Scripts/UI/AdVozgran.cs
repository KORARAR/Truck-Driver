using System.Runtime.InteropServices;
using UnityEngine;

public class AdVozgran : MonoBehaviour
{
    [SerializeField] private LVLprefabs lVLprefabs;
    [DllImport("__Internal")]

    private static extern void ShowAdVozgran();

    public void PokazatAd()
    {
        if(VibraniLVL.ViborLVL == lVLprefabs.LVLprefab.Length) { return; }
        ShowAdVozgran();
    }
}
