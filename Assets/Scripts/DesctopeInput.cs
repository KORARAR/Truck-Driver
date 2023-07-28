using UnityEngine;

public class DesctopeInput : MonoBehaviour
{
    [SerializeField] private CarInput carInput;


    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) { carInput.Gaz(); return; }
        if (Input.GetKey(KeyCode.D)) { carInput.ObratniGaz(); return; }
        else { carInput.Otpustili(); }
    }
}
