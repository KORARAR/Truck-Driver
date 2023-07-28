using UnityEngine;

public class ViborLVL : MonoBehaviour
{
    [SerializeField] private LVL lvl;

    public void PlayLVL()
    {
        if (!PlayerPrefs.HasKey("QStars" + lvl.IdLVL) && lvl.IdLVL != 1) { return; }
        
        //Debug.Log($"выбран {lvl.IdLVL} уровень");
        VibraniLVL.Save(lvl.IdLVL);
        ScenesPerehod.Perehod(1);
    }
}
