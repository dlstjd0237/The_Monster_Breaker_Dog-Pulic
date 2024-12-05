//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/08_InputSystem/SoulInput.inputactions
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

public partial class @SoulInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @SoulInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SoulInput"",
    ""maps"": [
        {
            ""name"": ""OnFloor"",
            ""id"": ""b236af67-1d2d-4d45-a9e0-5b5243d76cd6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""23245921-328a-43d0-8f40-bffe7d4721f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""9341e63d-42a1-45fe-8970-1865e9b59ef3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6bb8e1a8-f465-4a8d-847a-7af5f73e3aa8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c26c27e8-5571-4796-8f4b-754b1e47aec8"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""OnText"",
            ""id"": ""dc83a746-3625-4f4d-8212-e3e8610e1350"",
            ""actions"": [
                {
                    ""name"": ""NextText"",
                    ""type"": ""Button"",
                    ""id"": ""8302b214-d031-4c06-9395-34f804ccb4a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3a973e03-a077-43f7-8eb0-c8d4a5d96093"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextText"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // OnFloor
        m_OnFloor = asset.FindActionMap("OnFloor", throwIfNotFound: true);
        m_OnFloor_Move = m_OnFloor.FindAction("Move", throwIfNotFound: true);
        m_OnFloor_Interact = m_OnFloor.FindAction("Interact", throwIfNotFound: true);
        // OnText
        m_OnText = asset.FindActionMap("OnText", throwIfNotFound: true);
        m_OnText_NextText = m_OnText.FindAction("NextText", throwIfNotFound: true);
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

    // OnFloor
    private readonly InputActionMap m_OnFloor;
    private List<IOnFloorActions> m_OnFloorActionsCallbackInterfaces = new List<IOnFloorActions>();
    private readonly InputAction m_OnFloor_Move;
    private readonly InputAction m_OnFloor_Interact;
    public struct OnFloorActions
    {
        private @SoulInput m_Wrapper;
        public OnFloorActions(@SoulInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_OnFloor_Move;
        public InputAction @Interact => m_Wrapper.m_OnFloor_Interact;
        public InputActionMap Get() { return m_Wrapper.m_OnFloor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnFloorActions set) { return set.Get(); }
        public void AddCallbacks(IOnFloorActions instance)
        {
            if (instance == null || m_Wrapper.m_OnFloorActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OnFloorActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IOnFloorActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IOnFloorActions instance)
        {
            if (m_Wrapper.m_OnFloorActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOnFloorActions instance)
        {
            foreach (var item in m_Wrapper.m_OnFloorActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OnFloorActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OnFloorActions @OnFloor => new OnFloorActions(this);

    // OnText
    private readonly InputActionMap m_OnText;
    private List<IOnTextActions> m_OnTextActionsCallbackInterfaces = new List<IOnTextActions>();
    private readonly InputAction m_OnText_NextText;
    public struct OnTextActions
    {
        private @SoulInput m_Wrapper;
        public OnTextActions(@SoulInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextText => m_Wrapper.m_OnText_NextText;
        public InputActionMap Get() { return m_Wrapper.m_OnText; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnTextActions set) { return set.Get(); }
        public void AddCallbacks(IOnTextActions instance)
        {
            if (instance == null || m_Wrapper.m_OnTextActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OnTextActionsCallbackInterfaces.Add(instance);
            @NextText.started += instance.OnNextText;
            @NextText.performed += instance.OnNextText;
            @NextText.canceled += instance.OnNextText;
        }

        private void UnregisterCallbacks(IOnTextActions instance)
        {
            @NextText.started -= instance.OnNextText;
            @NextText.performed -= instance.OnNextText;
            @NextText.canceled -= instance.OnNextText;
        }

        public void RemoveCallbacks(IOnTextActions instance)
        {
            if (m_Wrapper.m_OnTextActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOnTextActions instance)
        {
            foreach (var item in m_Wrapper.m_OnTextActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OnTextActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OnTextActions @OnText => new OnTextActions(this);
    public interface IOnFloorActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IOnTextActions
    {
        void OnNextText(InputAction.CallbackContext context);
    }
}