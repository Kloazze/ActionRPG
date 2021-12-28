using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player Singleton;

    // PLAYER COMPONENTS
    [HideInInspector]
    public PlayerMovement movement;
    [HideInInspector]
    public PlayerAnimations animations;
    [HideInInspector]
    public PlayerCollision collision;
    [HideInInspector]
    public PlayerAppearance appearance;
    [HideInInspector]
    public PlayerTargeting targeting;
    [HideInInspector]
    public PlayerCameras cameras;

    // PHYSICS
    [HideInInspector]
    public Rigidbody rb;
    [HideInInspector]
    public CapsuleCollider capsColl;

    // Unlockables
    [HideInInspector]
    public bool isMaskUnlocked;
    //[HideInInspector]
    public bool isSwordUnlocked;
    [HideInInspector]
    public bool isDashUnlocked;
    [HideInInspector]
    public bool areWingsUnlocked;

    // Respawning

    void Awake()
    {
        Singleton = this;

        // PLAYER COMPONENTS
        movement = GetComponent<PlayerMovement>();
        animations = GetComponent<PlayerAnimations>();
        collision = GetComponent<PlayerCollision>();
        appearance = GetComponent<PlayerAppearance>();
        targeting = GetComponent<PlayerTargeting>();
        cameras = GetComponent<PlayerCameras>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // PHYSICS
        rb = GetComponent<Rigidbody>();
        capsColl = GetComponent<CapsuleCollider>();

        // INPUTS
        InputManager.Singleton.EnableInputs();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UnParent()
    {
        transform.parent = null;
    }

    public void UnlockMask()
    {
        
        GameManager.Singleton.UnlockMask();

        appearance.ShowMask();
    }

    public void UnlockDash()
    {
        GameManager.Singleton.UnlockDash();

        movement.isDashUnlocked = true;
    }

    public void UnlockWings()
    {
        GameManager.Singleton.UnlockWings();

        movement.doubleJumpEnabled = true;
        appearance.ShowWings();
    }
    
}
