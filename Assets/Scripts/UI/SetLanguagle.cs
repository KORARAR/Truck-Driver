using System.Runtime.InteropServices;
using UnityEngine;

public class SetLanguagle : MonoBehaviour
{
    [DllImport("__Internal")]

    private static extern string GetLang();

    private void Awake()
    {
        Languagle.NameLang = GetLang();
    }
}
