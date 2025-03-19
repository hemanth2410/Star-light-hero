using System;
using UnityEngine;

public class InputListenner : MonoBehaviour
{
    EventBinding<PlayerInput> inputEventBinding;
    [SerializeField] Vector2 m_MoveVector;
    [SerializeField] Vector2 m_LookVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputEventBinding = new EventBinding<PlayerInput>(playerInput);
        EventBus<PlayerInput>.Register(inputEventBinding);
    }

    private void playerInput(PlayerInput input)
    {
        m_MoveVector = input.movement;
        m_LookVector = input.look;
    }
}
