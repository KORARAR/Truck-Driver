using UnityEngine;

public class MobileInput : MonoBehaviour
{
    [SerializeField] private CarInput carInput;

    public void Gaz() { carInput.Gaz(); }
    public void ObratniGaz() { carInput.ObratniGaz(); }
    public void Otpustili() { carInput.Otpustili(); }
}
