// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Everything"",
            ""id"": ""7c3f1268-2bfe-4402-a392-1f0b7fd98806"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""7a87179c-0b57-47c2-9fff-b2b31e498675"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""6cd839fe-b1ef-4525-935d-a15173d4b328"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""872481f1-2707-4e13-89c0-572bdc21cf31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""5eef391c-47d3-4441-96a9-5d9ee7ce2db2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Bottom"",
                    ""type"": ""Button"",
                    ""id"": ""f7f38e68-6127-4df6-ae85-7d0d78dcbe14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""d3e7504e-d15a-46c4-97b0-3019df6dc299"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""3a75ea5e-5b0d-4b2b-9744-9fa035156ec0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""3ae0b714-381d-4829-be1b-66e985aceecb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LS"",
                    ""type"": ""Button"",
                    ""id"": ""7f1e2e66-e136-4763-87c3-94a4205b3596"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LT"",
                    ""type"": ""Button"",
                    ""id"": ""a01f4294-81c1-4cf5-8d0b-c1affa943048"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RS"",
                    ""type"": ""Button"",
                    ""id"": ""28cee422-bace-4458-8c3c-878c8827323e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RT"",
                    ""type"": ""Button"",
                    ""id"": ""96549ef6-25cd-404c-af20-b231fb84a0d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Button"",
                    ""id"": ""dfe717ae-80c5-4c53-a06f-1601d20e0f3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Button"",
                    ""id"": ""60a4bae9-9f73-412a-aa31-f22ca3cfa8cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""10f3fcfd-de16-4b8d-aa4d-9753c5d28850"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4c83a02-4ce4-494c-a6bd-55413001f842"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac5144bf-6d6b-4270-ace1-af3b36819cc6"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""257db5f9-23bb-4b8b-9e44-89dfb8f68b45"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0c9618a-4f37-40f2-a055-567e61f0ef89"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bottom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d04dbf10-1495-45d0-be10-3ce2d26c5cfc"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f92a6532-0d97-4ba0-af2f-9312930bb493"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1de27c0d-2c7c-4369-b854-6be0b588a8cd"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02dfa43b-2704-41a6-be40-52b5bbcb1588"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c671bbf-0af6-4fa1-943e-a4b288cf02a9"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b33e37e-ade9-4331-a524-5ff1c8832ef3"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74d160cb-f2f3-4899-9d48-c0ede1d87ff7"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca767482-9de2-4b10-bda9-6aac096d002f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70c0c3e6-53ab-4056-ba07-14fc1fdcb8fc"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Everything
        m_Everything = asset.FindActionMap("Everything", throwIfNotFound: true);
        m_Everything_A = m_Everything.FindAction("A", throwIfNotFound: true);
        m_Everything_B = m_Everything.FindAction("B", throwIfNotFound: true);
        m_Everything_X = m_Everything.FindAction("X", throwIfNotFound: true);
        m_Everything_Y = m_Everything.FindAction("Y", throwIfNotFound: true);
        m_Everything_Bottom = m_Everything.FindAction("Bottom", throwIfNotFound: true);
        m_Everything_Right = m_Everything.FindAction("Right", throwIfNotFound: true);
        m_Everything_Left = m_Everything.FindAction("Left", throwIfNotFound: true);
        m_Everything_Up = m_Everything.FindAction("Up", throwIfNotFound: true);
        m_Everything_LS = m_Everything.FindAction("LS", throwIfNotFound: true);
        m_Everything_LT = m_Everything.FindAction("LT", throwIfNotFound: true);
        m_Everything_RS = m_Everything.FindAction("RS", throwIfNotFound: true);
        m_Everything_RT = m_Everything.FindAction("RT", throwIfNotFound: true);
        m_Everything_LeftStick = m_Everything.FindAction("LeftStick", throwIfNotFound: true);
        m_Everything_RightStick = m_Everything.FindAction("RightStick", throwIfNotFound: true);
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

    // Everything
    private readonly InputActionMap m_Everything;
    private IEverythingActions m_EverythingActionsCallbackInterface;
    private readonly InputAction m_Everything_A;
    private readonly InputAction m_Everything_B;
    private readonly InputAction m_Everything_X;
    private readonly InputAction m_Everything_Y;
    private readonly InputAction m_Everything_Bottom;
    private readonly InputAction m_Everything_Right;
    private readonly InputAction m_Everything_Left;
    private readonly InputAction m_Everything_Up;
    private readonly InputAction m_Everything_LS;
    private readonly InputAction m_Everything_LT;
    private readonly InputAction m_Everything_RS;
    private readonly InputAction m_Everything_RT;
    private readonly InputAction m_Everything_LeftStick;
    private readonly InputAction m_Everything_RightStick;
    public struct EverythingActions
    {
        private @Controls m_Wrapper;
        public EverythingActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Everything_A;
        public InputAction @B => m_Wrapper.m_Everything_B;
        public InputAction @X => m_Wrapper.m_Everything_X;
        public InputAction @Y => m_Wrapper.m_Everything_Y;
        public InputAction @Bottom => m_Wrapper.m_Everything_Bottom;
        public InputAction @Right => m_Wrapper.m_Everything_Right;
        public InputAction @Left => m_Wrapper.m_Everything_Left;
        public InputAction @Up => m_Wrapper.m_Everything_Up;
        public InputAction @LS => m_Wrapper.m_Everything_LS;
        public InputAction @LT => m_Wrapper.m_Everything_LT;
        public InputAction @RS => m_Wrapper.m_Everything_RS;
        public InputAction @RT => m_Wrapper.m_Everything_RT;
        public InputAction @LeftStick => m_Wrapper.m_Everything_LeftStick;
        public InputAction @RightStick => m_Wrapper.m_Everything_RightStick;
        public InputActionMap Get() { return m_Wrapper.m_Everything; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EverythingActions set) { return set.Get(); }
        public void SetCallbacks(IEverythingActions instance)
        {
            if (m_Wrapper.m_EverythingActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnY;
                @Bottom.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnBottom;
                @Bottom.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnBottom;
                @Bottom.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnBottom;
                @Right.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRight;
                @Left.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLeft;
                @Up.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnUp;
                @LS.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLS;
                @LS.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLS;
                @LS.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLS;
                @LT.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLT;
                @LT.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLT;
                @LT.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLT;
                @RS.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRS;
                @RS.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRS;
                @RS.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRS;
                @RT.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRT;
                @RT.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRT;
                @RT.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRT;
                @LeftStick.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnLeftStick;
                @RightStick.started -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_EverythingActionsCallbackInterface.OnRightStick;
            }
            m_Wrapper.m_EverythingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @Bottom.started += instance.OnBottom;
                @Bottom.performed += instance.OnBottom;
                @Bottom.canceled += instance.OnBottom;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @LS.started += instance.OnLS;
                @LS.performed += instance.OnLS;
                @LS.canceled += instance.OnLS;
                @LT.started += instance.OnLT;
                @LT.performed += instance.OnLT;
                @LT.canceled += instance.OnLT;
                @RS.started += instance.OnRS;
                @RS.performed += instance.OnRS;
                @RS.canceled += instance.OnRS;
                @RT.started += instance.OnRT;
                @RT.performed += instance.OnRT;
                @RT.canceled += instance.OnRT;
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
            }
        }
    }
    public EverythingActions @Everything => new EverythingActions(this);
    public interface IEverythingActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnBottom(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnLS(InputAction.CallbackContext context);
        void OnLT(InputAction.CallbackContext context);
        void OnRS(InputAction.CallbackContext context);
        void OnRT(InputAction.CallbackContext context);
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
    }
}
