using UnityEngine;
using UnityEngine.InputSystem;

public class get_inputs : MonoBehaviour
{
    public InputAction player_controls;

    public Vector2 movementInputVector;

    public player_movement_functions player_Movement_Functions_konkret;

    private void OnEnable()
    {
        player_controls.Enable();
    }

    private void OnDisable()
    {
        player_controls.Disable();
    }

    private void Start()
    {
    }

    private void Update()
    {
        movementInputVector = player_controls.ReadValue<Vector2>();
        Debug.Log("Input_Vector: " + movementInputVector);

        // Ruft die ExecuteMovement Funktion des anderen scripts auf
        player_Movement_Functions_konkret.ExecuteMovement(movementInputVector);
    }
}
