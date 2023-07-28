using UnityEngine;
using UnityEngine.UI;

public class BoxesText : MonoBehaviour
{
    [SerializeField] private Text BoxText;
    private LangText langText;

    public void UpdateText(string text)
    {
        BoxText.text = langText.TextInLang[Languagle.IDLang] + ": " + text;
    }

    private void Awake() { langText = GetComponent<LangText>(); }
}
