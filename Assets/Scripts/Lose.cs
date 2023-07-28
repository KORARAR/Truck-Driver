using UnityEngine;

public class Lose : MonoBehaviour
{
    [SerializeField] private BoxColVo BoxesColVo;
    [SerializeField] private BoxesText boxesText;
    [SerializeField] private CarController carController;

    public void YouLose()
    {
        boxesText.UpdateText(BoxesColVo.ColVoBoxes.ToString());

        if(BoxesColVo.ColVoBoxes > 0) { return; }

        carController.MotorSpeed0();
        PanelsPerehod.Pokazat(2);
        PanelsPerehod.Spratat(0);
        Invoke("GameStop", 2f);
    }

    private void GameStop() 
    {
         Time.timeScale = 0;
    }

    private void Start()
    {
        Invoke("YouLose", 0.01f);
    }
}
