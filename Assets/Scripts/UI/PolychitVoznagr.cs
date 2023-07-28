using System.Runtime.InteropServices;
using UnityEngine;

public class PolychitVoznagr : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void MsgVivod();

    public void VoznagrPolych()
    {
        VibraniLVL.Save(VibraniLVL.ViborLVL + 1);
        MsgVivod();
        ScenesPerehod.Perehod(1);
    }
}
