// GENERATED AUTOMATICALLY FROM 'Assets/Player/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ca06452d-108b-4dc3-b23c-55c90d0309af"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6e5ccff5-b290-4ebe-ac27-3f8f09881609"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""536b92d7-a9b2-49fb-9a65-f7d1eef52c42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3ee9973b-ddef-41f7-92b9-4fc9051b77fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Light Attack"",
                    ""type"": ""Button"",
                    ""id"": ""0a59573e-17ff-485c-9fcc-2ab5fe54c16c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5177c0b0-8e05-43ab-a425-a7b995ae04a1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""a8ea2940-6d36-46c9-a82d-f7daab27a6d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Heavy Attack"",
                    ""type"": ""Button"",
                    ""id"": ""7a463e0b-8524-4518-9c10-19568945c495"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Two-Handing"",
                    ""type"": ""Button"",
                    ""id"": ""db4049e4-798d-4701-b8e4-1696ccc8e88e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapons Quick Slots: Up"",
                    ""type"": ""Button"",
                    ""id"": ""4fe24fc5-7c34-455e-912f-c943899864f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapons Quick Slots: Down"",
                    ""type"": ""Button"",
                    ""id"": ""a0288f31-1ae4-4361-81e2-d6d9e488883d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapons Quick Slots: Left"",
                    ""type"": ""Button"",
                    ""id"": ""09d9ad4c-bfcb-4d28-9c87-e594b17abe02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapons Quick Slots: Right"",
                    ""type"": ""Button"",
                    ""id"": ""8950bd06-2222-4ed8-aab3-a875e6870e62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2d41b2da-acbb-4171-8668-2a449d668042"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""812ab5e8-4de4-432b-b62d-4744b3e3a923"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Character Equipment"",
                    ""type"": ""Button"",
                    ""id"": ""eb08aaa8-5418-4294-9ff8-5fb0049fa9a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use Item"",
                    ""type"": ""Button"",
                    ""id"": ""44379d95-9fb8-464e-9c17-6740fb403ea0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""2bcd5443-ad75-4aa5-9859-455be5a4129d"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""96916a34-981d-4625-920e-ee73806ec9f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fbd60223-1334-4f61-9c7d-972f606951bb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2392e3b3-4043-42e6-8c12-ee34acccb4cd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""827c8ec3-6beb-4f99-8258-24c86080f778"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c33f19e9-9cce-4a45-84f3-7c2031eaefc5"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f65a8948-5f14-4f8c-b1fd-aaedd51557a5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d16b61c-e0e6-40f9-a026-b3e9cbc4d8d0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Light Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8ea222d-a8a6-4348-9289-cc607a687f6e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a162e1a6-cbf5-410d-8af3-7016867d67b3"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""738248f3-b57a-48eb-a1ad-58714005ac6d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Heavy Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1733233-f45f-4d8e-83f6-c6ccea58cd8a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapons Quick Slots: Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""031224d2-fc68-402e-9bd9-4b39e6fe3b1e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapons Quick Slots: Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a52cd2f-3550-4ab8-b0f0-f68450910a35"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapons Quick Slots: Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b78e38b-1fe5-4e26-928f-7eb7b66439e0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapons Quick Slots: Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe40ef16-30e7-40a6-b168-3c8a16253b3d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04cfc914-ffb9-439f-bc0c-2300eb6d05bc"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c96db34-136a-4ee7-93ac-fe7e39229693"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Character Equipment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6432c8db-550c-42f7-81a2-deaeb5cdf3de"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Two-Handing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""512395dd-bca5-4535-8c6d-743acac50be8"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Item"",
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
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_LightAttack = m_Player.FindAction("Light Attack", throwIfNotFound: true);
        m_Player_Camera = m_Player.FindAction("Camera", throwIfNotFound: true);
        m_Player_Roll = m_Player.FindAction("Roll", throwIfNotFound: true);
        m_Player_HeavyAttack = m_Player.FindAction("Heavy Attack", throwIfNotFound: true);
        m_Player_TwoHanding = m_Player.FindAction("Two-Handing", throwIfNotFound: true);
        m_Player_WeaponsQuickSlotsUp = m_Player.FindAction("Weapons Quick Slots: Up", throwIfNotFound: true);
        m_Player_WeaponsQuickSlotsDown = m_Player.FindAction("Weapons Quick Slots: Down", throwIfNotFound: true);
        m_Player_WeaponsQuickSlotsLeft = m_Player.FindAction("Weapons Quick Slots: Left", throwIfNotFound: true);
        m_Player_WeaponsQuickSlotsRight = m_Player.FindAction("Weapons Quick Slots: Right", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Inventory = m_Player.FindAction("Inventory", throwIfNotFound: true);
        m_Player_CharacterEquipment = m_Player.FindAction("Character Equipment", throwIfNotFound: true);
        m_Player_UseItem = m_Player.FindAction("Use Item", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_LightAttack;
    private readonly InputAction m_Player_Camera;
    private readonly InputAction m_Player_Roll;
    private readonly InputAction m_Player_HeavyAttack;
    private readonly InputAction m_Player_TwoHanding;
    private readonly InputAction m_Player_WeaponsQuickSlotsUp;
    private readonly InputAction m_Player_WeaponsQuickSlotsDown;
    private readonly InputAction m_Player_WeaponsQuickSlotsLeft;
    private readonly InputAction m_Player_WeaponsQuickSlotsRight;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Inventory;
    private readonly InputAction m_Player_CharacterEquipment;
    private readonly InputAction m_Player_UseItem;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @LightAttack => m_Wrapper.m_Player_LightAttack;
        public InputAction @Camera => m_Wrapper.m_Player_Camera;
        public InputAction @Roll => m_Wrapper.m_Player_Roll;
        public InputAction @HeavyAttack => m_Wrapper.m_Player_HeavyAttack;
        public InputAction @TwoHanding => m_Wrapper.m_Player_TwoHanding;
        public InputAction @WeaponsQuickSlotsUp => m_Wrapper.m_Player_WeaponsQuickSlotsUp;
        public InputAction @WeaponsQuickSlotsDown => m_Wrapper.m_Player_WeaponsQuickSlotsDown;
        public InputAction @WeaponsQuickSlotsLeft => m_Wrapper.m_Player_WeaponsQuickSlotsLeft;
        public InputAction @WeaponsQuickSlotsRight => m_Wrapper.m_Player_WeaponsQuickSlotsRight;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Inventory => m_Wrapper.m_Player_Inventory;
        public InputAction @CharacterEquipment => m_Wrapper.m_Player_CharacterEquipment;
        public InputAction @UseItem => m_Wrapper.m_Player_UseItem;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @LightAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttack;
                @LightAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttack;
                @LightAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttack;
                @Camera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Roll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @HeavyAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHeavyAttack;
                @TwoHanding.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTwoHanding;
                @TwoHanding.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTwoHanding;
                @TwoHanding.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTwoHanding;
                @WeaponsQuickSlotsUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsUp;
                @WeaponsQuickSlotsUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsUp;
                @WeaponsQuickSlotsUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsUp;
                @WeaponsQuickSlotsDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsDown;
                @WeaponsQuickSlotsDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsDown;
                @WeaponsQuickSlotsDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsDown;
                @WeaponsQuickSlotsLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsLeft;
                @WeaponsQuickSlotsLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsLeft;
                @WeaponsQuickSlotsLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsLeft;
                @WeaponsQuickSlotsRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsRight;
                @WeaponsQuickSlotsRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsRight;
                @WeaponsQuickSlotsRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponsQuickSlotsRight;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Inventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @CharacterEquipment.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCharacterEquipment;
                @CharacterEquipment.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCharacterEquipment;
                @CharacterEquipment.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCharacterEquipment;
                @UseItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseItem;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @LightAttack.started += instance.OnLightAttack;
                @LightAttack.performed += instance.OnLightAttack;
                @LightAttack.canceled += instance.OnLightAttack;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @HeavyAttack.started += instance.OnHeavyAttack;
                @HeavyAttack.performed += instance.OnHeavyAttack;
                @HeavyAttack.canceled += instance.OnHeavyAttack;
                @TwoHanding.started += instance.OnTwoHanding;
                @TwoHanding.performed += instance.OnTwoHanding;
                @TwoHanding.canceled += instance.OnTwoHanding;
                @WeaponsQuickSlotsUp.started += instance.OnWeaponsQuickSlotsUp;
                @WeaponsQuickSlotsUp.performed += instance.OnWeaponsQuickSlotsUp;
                @WeaponsQuickSlotsUp.canceled += instance.OnWeaponsQuickSlotsUp;
                @WeaponsQuickSlotsDown.started += instance.OnWeaponsQuickSlotsDown;
                @WeaponsQuickSlotsDown.performed += instance.OnWeaponsQuickSlotsDown;
                @WeaponsQuickSlotsDown.canceled += instance.OnWeaponsQuickSlotsDown;
                @WeaponsQuickSlotsLeft.started += instance.OnWeaponsQuickSlotsLeft;
                @WeaponsQuickSlotsLeft.performed += instance.OnWeaponsQuickSlotsLeft;
                @WeaponsQuickSlotsLeft.canceled += instance.OnWeaponsQuickSlotsLeft;
                @WeaponsQuickSlotsRight.started += instance.OnWeaponsQuickSlotsRight;
                @WeaponsQuickSlotsRight.performed += instance.OnWeaponsQuickSlotsRight;
                @WeaponsQuickSlotsRight.canceled += instance.OnWeaponsQuickSlotsRight;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @CharacterEquipment.started += instance.OnCharacterEquipment;
                @CharacterEquipment.performed += instance.OnCharacterEquipment;
                @CharacterEquipment.canceled += instance.OnCharacterEquipment;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLightAttack(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnHeavyAttack(InputAction.CallbackContext context);
        void OnTwoHanding(InputAction.CallbackContext context);
        void OnWeaponsQuickSlotsUp(InputAction.CallbackContext context);
        void OnWeaponsQuickSlotsDown(InputAction.CallbackContext context);
        void OnWeaponsQuickSlotsLeft(InputAction.CallbackContext context);
        void OnWeaponsQuickSlotsRight(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnCharacterEquipment(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
    }
}
