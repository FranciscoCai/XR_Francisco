using UnityEngine;
using UnityEngine.InputSystem;

public class MyPlayer : MonoBehaviour
{
    public Vector2 m_Movement;
    private InputSystem_Actions m_Actions;
    void Awake()
    {
        m_Actions = new InputSystem_Actions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        m_Actions.Player.Move.performed += OnMove;
    }
    private void OnDisable()
    {
        m_Actions.Player.Move.performed -= OnMove;
    }
    private void OnMove(InputAction.CallbackContext context)
    {
        m_Movement = context.ReadValue<Vector2>();
    }
}
