using Cinemachine;
//using System.Collections;
using UnityEngine;

public class CamRazreshenIzmen : MonoBehaviour
{
    [SerializeField] private static CinemachineVirtualCamera cinemachine;

    public static void Otdalenie(float NaScolkoOtdalit)
    {
        if(NaScolkoOtdalit > 6)
        cinemachine.m_Lens.OrthographicSize = NaScolkoOtdalit;
    }

    //public static IEnumerator StopCar()
    //{
    //    while(cinemachine.m_Lens.OrthographicSize > 6)
    //    {
    //        cinemachine.m_Lens.OrthographicSize -= 0.01f;
    //        yield return new WaitForSeconds(0.1f);
    //    }
    //}

    private void Start() { cinemachine = GetComponent<CinemachineVirtualCamera>(); }
}
