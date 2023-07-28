using System.Runtime.InteropServices;
using UnityEngine;

public class AdPokaz : MonoBehaviour
{
    [DllImport("__Internal")]

    private static extern void ShowAd();
    private void Start() { ShowAd(); }
}
