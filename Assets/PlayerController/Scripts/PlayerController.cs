using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Cinemachine")]
	[Tooltip("The follow target set in the Cinemachine Virtual Camera that the camera will follow")]
	public GameObject CinemachineCameraTarget;
	[Tooltip("How far in degrees can you move the camera up")]
	public float TopClamp = 90.0f;
	[Tooltip("How far in degrees can you move the camera down")]
	public float BottomClamp = -90.0f;

	// cinemachine
	private float cinemachineTargetPitch;
    
    // input system
    private PlayerInput playerInput;
    private InputAction look;
    private GameObject mainCamera;

    private bool IsCurrentDeviceMouse
    {
        get
        {
            return this.playerInput.currentControlScheme == "KeyboardMouse";
        }
    }

    private void Awake()
    {
        // Get a reference for the main camera
        if(this.mainCamera == null)
        {
            this.mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CameraRotation()
    {
        InputAction look = this.playerInput.actions.FindAction("Look");
    }
    private void Move()
    {

    }
}
