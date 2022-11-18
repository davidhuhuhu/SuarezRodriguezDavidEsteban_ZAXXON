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
                },
                {
                    ""name"": ""StrongShot"",
                    ""type"": ""Button"",
                    ""id"": ""bf1f038f-35c7-4b25-86da-d53d1a4f2b8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shot"",
                    ""type"": ""Button"",
                    ""id"": ""a836f56d-0f03-495b-8471-567aee0e22e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DodgeL"",
                    ""type"": ""Button"",
                    ""id"": ""445cbf9d-d020-400c-8926-fa39417b3e4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DodgeR"",
                    ""type"": ""Button"",
                    ""id"": ""7875e6e5-349a-4905-ab25-bfa69f9da501"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
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
                    ""id"": ""46518c06-897b-4d11-a12d-3f46d8aa58df"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d366d477-39cf-4140-bfd0-ef6df639f5c1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a7a22693-12f8-4e5e-98ce-fc77c1eac5f9"",
                    ""path"": ""<Keyboard>/s"",
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
                    ""id"": ""ce7eb08c-db35-42b0-86ec-efacf0587416"",
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
                    ""id"": ""19de9420-ace1-4c9b-98a9-787211c3b54a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""10d3109f-2165-49a4-bc4b-4d2b1d6e1746"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ea0f9372-4539-4aa8-b40c-b4101cca46a0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrongShot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""161cff7b-b7ea-4f94-9b49-aebd55707387"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrongShot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
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
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3842fb1-2ec2-4008-b444-33901344a581"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b504057-2967-420c-af73-1213dbfa592f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Control"",
            ""id"": ""a9b79336-f7fc-4a7e-b5fa-b06e76afd1bd"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""878457eb-1645-4dae-a490-fbca712b4f25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Highscore"",
                    ""type"": ""Button"",
                    ""id"": ""3b8f723a-4776-4fd7-a4e5-9fc162f91ff1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8e8c9845-310a-4ce5-9740-26ffb18650ab"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e19ff83-6d57-4c42-9d84-7287bb40f931"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f2987aa-9d4c-465b-ad76-99f579f58ee6"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Highscore"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_Move = m_Weapon.FindAction("Move", throwIfNotFound: true);
        m_Weapon_MoveV = m_Weapon.FindAction("MoveV", throwIfNotFound: true);
        m_Weapon_MoveH = m_Weapon.FindAction("MoveH", throwIfNotFound: true);
        m_Weapon_StrongShot = m_Weapon.FindAction("StrongShot", throwIfNotFound: true);
        m_Weapon_Shot = m_Weapon.FindAction("Shot", throwIfNotFound: true);
        m_Weapon_DodgeL = m_Weapon.FindAction("DodgeL", throwIfNotFound: true);
        m_Weapon_DodgeR = m_Weapon.FindAction("DodgeR", throwIfNotFound: true);
        // Control
        m_Control = asset.FindActionMap("Control", throwIfNotFound: true);
        m_Control_Pause = m_Control.FindAction("Pause", throwIfNotFound: true);
        m_Control_Highscore = m_Control.FindAction("Highscore", throwIfNotFound: true);
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
    private readonly InputAction m_Weapon_Move;
    private readonly InputAction m_Weapon_MoveV;
    private readonly InputAction m_Weapon_MoveH;
    private readonly InputAction m_Weapon_StrongShot;
    private readonly InputAction m_Weapon_Shot;
    private readonly InputAction m_Weapon_DodgeL;
    private readonly InputAction m_Weapon_DodgeR;
    public struct WeaponActions
    {
        private @InputActions m_Wrapper;
        public WeaponActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Weapon_Move;
        public InputAction @MoveV => m_Wrapper.m_Weapon_MoveV;
        public InputAction @MoveH => m_Wrapper.m_Weapon_MoveH;
        public InputAction @StrongShot => m_Wrapper.m_Weapon_StrongShot;
        public InputAction @Shot => m_Wrapper.m_Weapon_Shot;
        public InputAction @DodgeL => m_Wrapper.m_Weapon_DodgeL;
        public InputAction @DodgeR => m_Wrapper.m_Weapon_DodgeR;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMove;
                @MoveV.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveV;
                @MoveV.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveV;
                @MoveV.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveV;
                @MoveH.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveH;
                @MoveH.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveH;
                @MoveH.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnMoveH;
                @StrongShot.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnStrongShot;
                @StrongShot.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnStrongShot;
                @StrongShot.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnStrongShot;
                @Shot.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnShot;
                @Shot.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnShot;
                @Shot.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnShot;
                @DodgeL.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnDodgeL;
                @DodgeL.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnDodgeL;
                @DodgeL.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnDodgeL;
                @DodgeR.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnDodgeR;
                @DodgeR.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnDodgeR;
                @DodgeR.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnDodgeR;
            }
            m_Wrapper.m_WeaponActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveV.started += instance.OnMoveV;
                @MoveV.performed += instance.OnMoveV;
                @MoveV.canceled += instance.OnMoveV;
                @MoveH.started += instance.OnMoveH;
                @MoveH.performed += instance.OnMoveH;
                @MoveH.canceled += instance.OnMoveH;
                @StrongShot.started += instance.OnStrongShot;
                @StrongShot.performed += instance.OnStrongShot;
                @StrongShot.canceled += instance.OnStrongShot;
                @Shot.started += instance.OnShot;
                @Shot.performed += instance.OnShot;
                @Shot.canceled += instance.OnShot;
                @DodgeL.started += instance.OnDodgeL;
                @DodgeL.performed += instance.OnDodgeL;
                @DodgeL.canceled += instance.OnDodgeL;
                @DodgeR.started += instance.OnDodgeR;
                @DodgeR.performed += instance.OnDodgeR;
                @DodgeR.canceled += instance.OnDodgeR;
            }
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);

    // Control
    private readonly InputActionMap m_Control;
    private IControlActions m_ControlActionsCallbackInterface;
    private readonly InputAction m_Control_Pause;
    private readonly InputAction m_Control_Highscore;
    public struct ControlActions
    {
        private @InputActions m_Wrapper;
        public ControlActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Control_Pause;
        public InputAction @Highscore => m_Wrapper.m_Control_Highscore;
        public InputActionMap Get() { return m_Wrapper.m_Control; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlActions set) { return set.Get(); }
        public void SetCallbacks(IControlActions instance)
        {
            if (m_Wrapper.m_ControlActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnPause;
                @Highscore.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnHighscore;
                @Highscore.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnHighscore;
                @Highscore.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnHighscore;
            }
            m_Wrapper.m_ControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Highscore.started += instance.OnHighscore;
                @Highscore.performed += instance.OnHighscore;
                @Highscore.canceled += instance.OnHighscore;
            }
        }
    }
    public ControlActions @Control => new ControlActions(this);
    public interface IWeaponActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveV(InputAction.CallbackContext context);
        void OnMoveH(InputAction.CallbackContext context);
        void OnStrongShot(InputAction.CallbackContext context);
        void OnShot(InputAction.CallbackContext context);
        void OnDodgeL(InputAction.CallbackContext context);
        void OnDodgeR(InputAction.CallbackContext context);
    }
    public interface IControlActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnHighscore(InputAction.CallbackContext context);
    }
}
