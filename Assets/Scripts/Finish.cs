using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private ScoreZaLVL scoreZaLVL;
    [SerializeField] private LVL lvl;
    [SerializeField] private BoxColVo boxColVo;
    [SerializeField] private LVLprefabs lVLprefabs;
    [SerializeField] private CarInput carInput;
    private bool YjeVrezalis;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Car" && !YjeVrezalis)
        {
            carInput.Otpustili();
            collision.gameObject.GetComponent<CarController>().MotorSpeed0();

            PanelsPerehod.Pokazat(3);
            PanelsPerehod.Spratat(0);

            scoreZaLVL.PrimenitStar();
            AnimationsUI.AnimPlay(0);

            lvl.QuantityStars = boxColVo.ColVoBoxes;
            lvl.Save();
            lVLprefabs.LVLprefab[lvl.IdLVL + 1].GetComponent<LVL>().Save();

            YjeVrezalis = true;
        }
    }
}
