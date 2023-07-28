using UnityEngine;

public class CarInput : MonoBehaviour
{
    [SerializeField] private CarController carController;
    private bool ZajaliGaz;
    private bool ZajaliObrGaz;

    
    private void Update()
    {
        if (ZajaliGaz) { if (carController.RazreshenieYscorenia) { carController.Yscorenie(1); } return; }
        if (ZajaliObrGaz) { if (carController.RazreshenieYscorenia) { carController.Yscorenie(-1); } return; }
    }
    
    public void Gaz()
    {
        carController.Poehali(1);
        ZajaliGaz = true;
    }
    
    public void ObratniGaz()
    {
        ZajaliObrGaz = true;
        carController.Poehali(-1);
    }

    public void Otpustili()
    {
        ZajaliGaz = false;
        ZajaliObrGaz = false;
        carController.Stop();
    }
}
