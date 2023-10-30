using UnityEngine;

public class TriggerDoorController2 : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "OPEN";


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            anim.SetTrigger(doorOpen);
            //s gameObject.SetActive(false);

        }
    }
}