using UnityEngine;

public class LVL : MonoBehaviour
{
    public int IdLVL;
    public int QuantityStars;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("QStars" + IdLVL.ToString()) && IdLVL != 1) { return; }
        QuantityStars = PlayerPrefs.GetInt("QStars" + IdLVL.ToString(), QuantityStars);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("QStars" + IdLVL.ToString(), QuantityStars);
    }
}
