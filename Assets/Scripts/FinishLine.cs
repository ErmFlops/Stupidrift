using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject youWinUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            youWinUI.SetActive(true);
            print("You Win!");
        }
    }
}
