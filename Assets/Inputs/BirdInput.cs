// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/BirdInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BirdInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BirdInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BirdInput"",
    ""maps"": [
        {
            ""name"": ""Bird"",
            ""id"": ""4feec90b-9c09-4fec-b599-2b0e0c4b0c97"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""96259fbe-3013-4b40-921c-ac7876fb9a7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""331cc1b0-2b54-487f-bd66-d475211d5d3b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02f37a9e-f26a-4557-8862-c961e2864014"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch Screen"",
                    ""action"": ""Jump"",
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
        },
        {
            ""name"": ""Touch Screen"",
            ""bindingGroup"": ""Touch Screen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Bird
        m_Bird = asset.FindActionMap("Bird", throwIfNotFound: true);
        m_Bird_Jump = m_Bird.FindAction("Jump", throwIfNotFound: true);
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

    // Bird
    private readonly InputActionMap m_Bird;
    private IBirdActions m_BirdActionsCallbackInterface;
    private readonly InputAction m_Bird_Jump;
    public struct BirdActions
    {
        private @BirdInput m_Wrapper;
        public BirdActions(@BirdInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Bird_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Bird; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdActions set) { return set.Get(); }
        public void SetCallbacks(IBirdActions instance)
        {
            if (m_Wrapper.m_BirdActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_BirdActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public BirdActions @Bird => new BirdActions(this);
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get
        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    private int m_TouchScreenSchemeIndex = -1;
    public InputControlScheme TouchScreenScheme
    {
        get
        {
            if (m_TouchScreenSchemeIndex == -1) m_TouchScreenSchemeIndex = asset.FindControlSchemeIndex("Touch Screen");
            return asset.controlSchemes[m_TouchScreenSchemeIndex];
        }
    }
    public interface IBirdActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
}
