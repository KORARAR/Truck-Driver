using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private BoxColVo BoxesColVo;
    [SerializeField] private Lose lose;
    [SerializeField] private GameObject BoxCrash;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Car")
        {
            BoxesColVo.ColVoBoxes--;
            lose.YouLose();
            GameObject bc = Instantiate(BoxCrash);
            bc.transform.position = gameObject.transform.position;
            Destroy(gameObject);
        }
    }
}
