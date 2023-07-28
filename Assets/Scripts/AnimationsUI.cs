using UnityEngine;

public class AnimationsUI : MonoBehaviour
{
    [SerializeField] private Animation[] anims;
    [SerializeField] private string[] animsName;

    [SerializeField] private static Animation[] animsS;
    [SerializeField] private static string[] animsNameS;


    public static void AnimPlay(int idAnim)
    {
        animsS[idAnim].Play(animsNameS[idAnim]);
    }

    private void Start()
    {
        animsS = new Animation[anims.Length];
        animsNameS = new string[anims.Length];

        for (int i = 0; i < anims.Length; i++)
        {
            animsS[i] = anims[i];
            animsNameS[i] = animsName[i];
        }
    }
}
