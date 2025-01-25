//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Modules/Inputs/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @IControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @IControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c455c7ad-c157-4903-a995-41e3b4918df2"",
            ""actions"": [
                {
                    ""name"": ""InputPosition"",
                    ""type"": ""Value"",
                    ""id"": ""93e07ada-9c33-4b28-a1c6-e5462cb662f3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""InputButton"",
                    ""type"": ""Button"",
                    ""id"": ""bc3448a9-87de-4f72-8fdd-580c80b49522"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InputKeyBinding"",
                    ""type"": ""Value"",
                    ""id"": ""caee1d1b-c316-48b2-a5ae-97dad847ee4e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""InputZoom"",
                    ""type"": ""Value"",
                    ""id"": ""abf465bf-ff7e-41c4-ae1f-e3cba5d9da32"",
                    ""expectedControlType"": ""Delta"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e2439426-86b5-4618-86f8-90d40f51b9dc"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b57c833-3b8f-4051-97f7-1fb11c649128"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00c364f7-ab29-465d-988c-86e6cc982fc1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39c0c2bf-93ba-42d2-91cb-faf8f4773333"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Keyboard"",
                    ""id"": ""4333d4b2-a81d-44b9-b39d-ff4203c44a47"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0a1f4faf-07ee-4ddb-9256-0d2920eeae3d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""44e14297-3b5d-41e7-922d-c5af69667d96"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0243892a-12c2-4923-84c3-73111980db3e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9e8d5b19-f238-4beb-85a1-2ec685303c9c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Mobile"",
                    ""id"": ""02230346-4979-4500-8f90-9af8c3d13aee"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c9b90cbd-8d24-46d8-acb4-d6b97ed3b756"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""571bc79b-711b-4c19-a63f-bb463f1f0d19"",
                    ""path"": ""<Touchscreen>/delta/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""65e14981-2b2a-4e9a-b1a9-669a8afdffce"",
                    ""path"": ""<Touchscreen>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""beb1d169-b796-455f-b8cf-978f4b4c54c5"",
                    ""path"": ""<Touchscreen>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKeyBinding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4a539748-ab00-4814-9c35-29f8cbc8fd46"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputZoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_InputPosition = m_Player.FindAction("InputPosition", throwIfNotFound: true);
        m_Player_InputButton = m_Player.FindAction("InputButton", throwIfNotFound: true);
        m_Player_InputKeyBinding = m_Player.FindAction("InputKeyBinding", throwIfNotFound: true);
        m_Player_InputZoom = m_Player.FindAction("InputZoom", throwIfNotFound: true);
    }

    ~@IControls()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, IControls.Player.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_InputPosition;
    private readonly InputAction m_Player_InputButton;
    private readonly InputAction m_Player_InputKeyBinding;
    private readonly InputAction m_Player_InputZoom;
    public struct PlayerActions
    {
        private @IControls m_Wrapper;
        public PlayerActions(@IControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @InputPosition => m_Wrapper.m_Player_InputPosition;
        public InputAction @InputButton => m_Wrapper.m_Player_InputButton;
        public InputAction @InputKeyBinding => m_Wrapper.m_Player_InputKeyBinding;
        public InputAction @InputZoom => m_Wrapper.m_Player_InputZoom;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @InputPosition.started += instance.OnInputPosition;
            @InputPosition.performed += instance.OnInputPosition;
            @InputPosition.canceled += instance.OnInputPosition;
            @InputButton.started += instance.OnInputButton;
            @InputButton.performed += instance.OnInputButton;
            @InputButton.canceled += instance.OnInputButton;
            @InputKeyBinding.started += instance.OnInputKeyBinding;
            @InputKeyBinding.performed += instance.OnInputKeyBinding;
            @InputKeyBinding.canceled += instance.OnInputKeyBinding;
            @InputZoom.started += instance.OnInputZoom;
            @InputZoom.performed += instance.OnInputZoom;
            @InputZoom.canceled += instance.OnInputZoom;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @InputPosition.started -= instance.OnInputPosition;
            @InputPosition.performed -= instance.OnInputPosition;
            @InputPosition.canceled -= instance.OnInputPosition;
            @InputButton.started -= instance.OnInputButton;
            @InputButton.performed -= instance.OnInputButton;
            @InputButton.canceled -= instance.OnInputButton;
            @InputKeyBinding.started -= instance.OnInputKeyBinding;
            @InputKeyBinding.performed -= instance.OnInputKeyBinding;
            @InputKeyBinding.canceled -= instance.OnInputKeyBinding;
            @InputZoom.started -= instance.OnInputZoom;
            @InputZoom.performed -= instance.OnInputZoom;
            @InputZoom.canceled -= instance.OnInputZoom;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnInputPosition(InputAction.CallbackContext context);
        void OnInputButton(InputAction.CallbackContext context);
        void OnInputKeyBinding(InputAction.CallbackContext context);
        void OnInputZoom(InputAction.CallbackContext context);
    }
}
