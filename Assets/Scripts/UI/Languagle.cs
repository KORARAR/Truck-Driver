using UnityEngine;

public class Languagle : MonoBehaviour
{
    public static int IDLang;
    public static string NameLang;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        if(NameLang == "ru") { IDLang = 0; return; }
        if(NameLang == "en") { IDLang = 1; return; }
        if(NameLang == "tr") { IDLang = 2; return; }
        IDLang = 1;
    }
}
