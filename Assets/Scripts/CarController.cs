using System.Collections;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private WheelJoint2D[] wheelJoints;
    [SerializeField] private Rigidbody2D rb;
    private JointMotor2D[] jointMotor;
    [SerializeField] private float TimeZaderzki;
    public bool RazreshenieYscorenia { get; set; } = true;


    public void Yscorenie(float NaSkolkoYscorenie)
    {
        if(jointMotor[1].motorSpeed <= 150) { NaSkolkoYscorenie += 150; }
        for (int i = 0; i < jointMotor.Length; i++)
        {
            jointMotor[i].motorSpeed += NaSkolkoYscorenie;
            wheelJoints[i].motor = jointMotor[i];
        }
        //CamRazreshenIzmen.Otdalenie(rb.velocity.magnitude * 3.6f * 0.1f);
        StartCoroutine(Zaderjka());
    }

    public void Stop()
    {
        for (int i = 0; i < jointMotor.Length; i++)
        {
            jointMotor[i].motorSpeed = 0;
            wheelJoints[i].motor = jointMotor[i];

            wheelJoints[i].useMotor = false;
        }
        //CamRazreshenIzmen.Otdalenie(rb.velocity.magnitude * 3.6f * 0.1f);
    }

    public void MotorSpeed0()
    {
        for (int i = 0; i < jointMotor.Length; i++)
        {
            jointMotor[i].motorSpeed = 0;
            wheelJoints[i].motor = jointMotor[i];
        }
        //CamRazreshenIzmen.Otdalenie(rb.velocity.magnitude * 3.6f * 0.1f);
    }

    public void Poehali(int VkakyuStorony)
    {
        float Speed = rb.velocity.magnitude * 3.6f; //находим скорость грузовка

        for (int i = 0; i < jointMotor.Length; i++)
        {
            wheelJoints[i].useMotor = true;

            jointMotor[i].motorSpeed = Speed * 23 * VkakyuStorony; //2.144 ;;  23 - это отношение скорости к скорости мотора
            wheelJoints[i].motor = jointMotor[i];
        }
    }

    private IEnumerator Zaderjka()
    {
        RazreshenieYscorenia = false;
        yield return new WaitForSeconds(TimeZaderzki);
        RazreshenieYscorenia = true;
    }

    private void Start()
    {
        jointMotor = new JointMotor2D[3];
        for (int i = 0; i < wheelJoints.Length; i++)
        {
            jointMotor[i] = wheelJoints[i].motor;
        }
    }
}
