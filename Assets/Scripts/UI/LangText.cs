using UnityEngine;
using UnityEngine.UI;

public class LangText : MonoBehaviour
{
    private Text text;
    public string[] TextInLang;


    public void Perevod()
    {
        text.text = TextInLang[Languagle.IDLang];
    }

    private void Start() { text = GetComponent<Text>();  Perevod(); }
}
