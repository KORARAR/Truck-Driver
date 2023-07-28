using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseActiveNextLVL : MonoBehaviour
{
    [SerializeField] private LVLprefabs lVLprefabs;


    private void Start() { if (VibraniLVL.ViborLVL >= lVLprefabs.LVLprefab.Length) { Destroy(gameObject); } }
}
