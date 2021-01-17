using UnityEngine;

public class model_movement : MonoBehaviour
{
    private bool MovePlayer = true;
    [SerializeField] float Movement_Speed = 0;

    // Update is called once per frame
    void Update()
    {
        if (!gameObject) // safe to check if our player actually available
            return;

        if (!MovePlayer)
            return;

        transform.position += (transform.forward*Movement_Speed*Time.deltaTime);
    }

    public void LetPlayerMove(bool letMove){
        this.MovePlayer = letMove;
    }
}
