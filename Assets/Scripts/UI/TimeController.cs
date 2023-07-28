using UnityEngine;

public class TimeController : MonoBehaviour
{
    [SerializeField] private int IndexVremeni;

    public static void VremaMenaisa(int indexIzmenenia) { Time.timeScale = indexIzmenenia; }
    private void Start() { VremaMenaisa(IndexVremeni); }
}
