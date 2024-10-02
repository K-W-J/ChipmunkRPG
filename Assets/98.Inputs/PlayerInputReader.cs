using System.Collections;
using System.Collections.Generic;
using Chipmunk.Library;
using UnityEngine;
using UnityEngine.InputSystem;
using static Controls;

public class PlayerInputReader : ScriptableSingleton<PlayerInputReader>, IPlayerActions
{
    Controls controls;
    public NotifyValue<Vector2> playerMoveDir = new();

    private void Awake()
    {
        controls = new();
        controls.Player.SetCallbacks(this);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        playerMoveDir.Value = context.ReadValue<Vector2>();
    }
}
