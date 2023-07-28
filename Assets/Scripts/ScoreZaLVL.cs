using UnityEngine;
using UnityEngine.UI;

public class ScoreZaLVL : MonoBehaviour
{
    [SerializeField] private Image[] StarImage;
    [SerializeField] private Sprite GoldStar;

    [SerializeField] private BoxColVo boxColVo;


    public void PrimenitStar()
    {
        for(int i = 0; i < boxColVo.ColVoBoxes; i++)
        {
            StarImage[i].sprite = GoldStar;
        }
    }
}
