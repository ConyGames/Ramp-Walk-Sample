using UnityEngine;

public class RemoveModel : MonoBehaviour
{
    [SerializeField] RampComtroller rampComtroller;


   private void OnTriggerEnter(Collider other)
   {
        if (other.tag != "Model")
            return;
        
        Debug.Log("Collided with Model");

        Destroy(rampComtroller.GetCurrentModel());
        if (!rampComtroller.GetCurrentModel()) // means somehow for some randome error our model allready deleted
            return;
        rampComtroller.SpawnNextModel();
   }
}
