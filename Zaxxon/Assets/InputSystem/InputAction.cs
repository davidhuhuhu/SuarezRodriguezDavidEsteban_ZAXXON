// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputAction"",
    ""maps"": [
        {
            ""name"": ""Weapon"",
            ""id"": ""b1e35ab3-41ff-4d8a-81b4-ae8920435cc6"",
            ""actions"": [
                {
                    ""name"": ""Shot"",
                    ""type"": ""Button"",
                    ""id"": ""a836f56d-0f03-495b-8471-567aee0e22e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""02df3703-bd27-45f1-9cf5-fee0b74088cf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveV"",
                    ""type"": ""Value"",
                    ""id"": ""eadbd2ca-ac2d-457a-919c-2ff83cfbcde0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveH"",
                    ""type"": ""Value"",
                    ""id"": ""c8ec8e7e-a7a6-4f04-a84c-974521da6e65"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4a9f3977-5ccc-49b2-ad5d-fce85f0f5f8d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26b52692-fd60-4afe-a060-ed59d7fa798a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce2be1f4-2fd4-4f60-b850-ab7b3510929c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c2ea02f9-98ce-4bf6-b779-a322a36b8d6a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""92c5460a-9084-402a-92b1-5b532d24e6b7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d218ccf2-a7e1-4584-9bf6-7e95ef60f9f9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8aa6cafb-da11-489a-9ac7-92ae1e4e4552"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5d15cc8f-bcbf-4107-8607-0c819d3fc5ec"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8485740f-176c-49d0-8233-9014f9f4919b"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""34331020-f8d9-4945-83d0-49b7ee10d0c5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""01857f5a-b21c-4549-90cf-b54c4c8eb9bb"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""264761ee-8634-42ab-919b-c2fcfcfd0d56"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e6178b2b-d905-470d-b9dd-015f478c16c8"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8d194fc6-b6f6-463b-91f5-898504f6582f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7f4a9859-6b87-4975-90da-40917d4e02f7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2603b98f-9716-4fc6-a68b-37f96fa51ebe"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_Shot = m_Weapon.FindAction("Shot", throwIfNotFound: true);
        m_Weapon_Move = m_Weapon.FindAction("Move", throwIfNotFound: true);
        m_Weapon_MoveV = m_Weapon.FindAction("MoveV", throwIfNotFound: true);
        m_Weapon_MoveH = m_Weapon.FindAction("MoveH", throwIfNotFound: true);
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

    // Weapon
    private readonly InputActionMap m_Weapon;
    private IWeaponActions m_WeaponActionsCallbackInterface;
    private readonly InputAction m_Weapon_Shot;
    private readonly InputAction m_Weapon_Move;
    private readonly InputAction m_Weapon_MoveV;
    private readonly InputAction m_Weapon_MoveH;
    public struct WeaponActions
    {
        private @InputActions m_Wrapper;
        public WeaponActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shot => m_Wrapper.m_Weapon_Shot;
        public InputAction @Move => m_Wrapper.m_Weapon_Move;
        public InputAction @MoveV => m_Wrapper.m_Weapon_MoveV;
        public InputAction @MoveH => m_Wrapper.m_Weapon_MoveH;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterface != null)
            {
                @Shot.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnShot;
                @Shot.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnShot;
                @Shot.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnShot;
                @Move.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMove;
                @MoveV.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveV;
                @MoveV.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveV;
                @MoveV.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveV;
                @MoveH.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveH;
                @MoveH.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveH;
                @MoveH.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveH;
            }
            m_Wrapper.m_WeaponActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shot.started += instance.OnShot;
                @Shot.performed += instance.OnShot;
                @Shot.canceled += instance.OnShot;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveV.started += instance.OnMoveV;
                @MoveV.performed += instance.OnMoveV;
                @MoveV.canceled += instance.OnMoveV;
                @MoveH.started += instance.OnMoveH;
                @MoveH.performed += instance.OnMoveH;
                @MoveH.canceled += instance.OnMoveH;
            }
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);
    public interface IWeaponActions
    {
        void OnShot(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnMoveV(InputAction.CallbackContext context);
        void OnMoveH(InputAction.CallbackContext context);
    }
}
