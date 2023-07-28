using UnityEngine;

public class LVLchtenie : MonoBehaviour
{
    [SerializeField] private GameObject[] ImageStarElement;
    [SerializeField] private LVL lvl;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("QStars" + lvl.IdLVL) && lvl.IdLVL != 1) { return; }

        ImageStarElement[0].SetActive(false);
        for (int i = 0; i < lvl.QuantityStars; i++)
        {
            ImageStarElement[i + 1].SetActive(true);
        }
    }
}
