using System.Collections.Generic;
using UnityEngine;

public class RampComtroller : MonoBehaviour
{
    
    [Header("Out Models")]
    [Tooltip("Choose the size that how many models you want to walk in ramp and select prefabs of the models")]
    [SerializeField] List<GameObject> Models;

    [Header("Positions")]
    [SerializeField] Transform StartingPoint;
    [SerializeField] Transform EndingPosition;

    [Header("Loop Model Spawn")]
    [Tooltip("It will Spawn Models in loop when true")]
    public bool SpawnInLoop = false;
    
    int model_index = 0;
    private GameObject CurrentModel;
    void Start()
    {
        if (Models.Count <= model_index) // that's mean user do not put any model to walk in ramp
            return;

        CurrentModel = Instantiate(Models[model_index],StartingPoint.position, transform.rotation, transform);
        CurrentModel.transform.eulerAngles = transform.eulerAngles;
        model_index++;
    }

    public void SpawnNextModel(){
        if (Models.Count <= model_index) // that's mean we are at the end of the models
        {
            if (!SpawnInLoop) return;
            else model_index = 0;
        }    

        CurrentModel = Instantiate(Models[model_index],StartingPoint.position, transform.rotation, transform);
        CurrentModel.transform.eulerAngles = transform.eulerAngles;
        model_index++;
    }

    /*
     * Rotate our player in a certain direction
     */
    public void RotateModel(ref Vector3 angle){
        if (!CurrentModel)
            return;

        CurrentModel.transform.eulerAngles += angle; // rotating the model
    }

    public GameObject GetCurrentModel(){
        return CurrentModel;
    }
}
