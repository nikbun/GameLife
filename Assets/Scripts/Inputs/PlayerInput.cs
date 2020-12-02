// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""cb573562-de62-4e13-91fb-717b8d17950b"",
            ""actions"": [
                {
                    ""name"": ""AddCell"",
                    ""type"": ""Button"",
                    ""id"": ""547210a4-4cc2-4e3b-9bc3-c435c28b891c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RemoveCell"",
                    ""type"": ""Button"",
                    ""id"": ""b4956ae2-c771-449c-a904-602575bb77e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""4949b30d-82eb-4867-99a4-5a781f98d745"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayPause"",
                    ""type"": ""Button"",
                    ""id"": ""c4a08d8f-7148-498d-ac9f-de2196f27e6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0fe0e129-f197-4a37-9ea4-c2f50a801e8a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""AddCell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cb66b8a-bd4f-4ac4-8e5a-cf38d7207456"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""PlayPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32e0a97c-2911-44a6-b3e3-a815f9d7bd37"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20028f6c-6af4-4cf0-9824-d3489e2e3b7c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""RemoveCell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_AddCell = m_Player.FindAction("AddCell", throwIfNotFound: true);
        m_Player_RemoveCell = m_Player.FindAction("RemoveCell", throwIfNotFound: true);
        m_Player_MousePosition = m_Player.FindAction("MousePosition", throwIfNotFound: true);
        m_Player_PlayPause = m_Player.FindAction("PlayPause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_AddCell;
    private readonly InputAction m_Player_RemoveCell;
    private readonly InputAction m_Player_MousePosition;
    private readonly InputAction m_Player_PlayPause;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @AddCell => m_Wrapper.m_Player_AddCell;
        public InputAction @RemoveCell => m_Wrapper.m_Player_RemoveCell;
        public InputAction @MousePosition => m_Wrapper.m_Player_MousePosition;
        public InputAction @PlayPause => m_Wrapper.m_Player_PlayPause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @AddCell.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAddCell;
                @AddCell.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAddCell;
                @AddCell.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAddCell;
                @RemoveCell.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveCell;
                @RemoveCell.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveCell;
                @RemoveCell.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveCell;
                @MousePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @PlayPause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayPause;
                @PlayPause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayPause;
                @PlayPause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AddCell.started += instance.OnAddCell;
                @AddCell.performed += instance.OnAddCell;
                @AddCell.canceled += instance.OnAddCell;
                @RemoveCell.started += instance.OnRemoveCell;
                @RemoveCell.performed += instance.OnRemoveCell;
                @RemoveCell.canceled += instance.OnRemoveCell;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @PlayPause.started += instance.OnPlayPause;
                @PlayPause.performed += instance.OnPlayPause;
                @PlayPause.canceled += instance.OnPlayPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get
        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnAddCell(InputAction.CallbackContext context);
        void OnRemoveCell(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnPlayPause(InputAction.CallbackContext context);
    }
}
