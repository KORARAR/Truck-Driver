using UnityEngine;

public class LVLprefabs : MonoBehaviour
{
    public GameObject[] LVLprefab;


    private void Start()
    {
        LVLprefab[VibraniLVL.ViborLVL].SetActive(true);
    }
}
