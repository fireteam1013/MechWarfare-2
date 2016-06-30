using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


    private GameObject cam;
    private GameObject camPivot;

    private ThirdPersonCharacter m_Character;   //Get class
    private Transform m_Cam;                    //Transform of the main camera
    private Vector3 m_CamForward;               //Direction facing forward
    private Vector3 m_Move;                     //Movement
    private Rigidbody rb;

    private float walkSpeed = 3f;
    private float jumpForce = 4f;
    private bool jump;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        camPivot = GameObject.Find("PlayerCamPivot");
        rb = GetComponent<Rigidbody>();
        if (Camera.main != null)
        {
            m_Cam = Camera.main.transform;
        }
        else
        {
            Debug.LogWarning("Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
            // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
        }
        m_Character = GetComponent<ThirdPersonCharacter>();
    }

    void Update()
        {
        float hm = Input.GetAxis("Mouse X");
        float vm = Input.GetAxis("Mouse Y");
        cam.transform.localPosition = new Vector3(camPivot.transform.localPosition.x, camPivot.transform.localPosition.y + 3f, camPivot.transform.localPosition.z - 4f);
        camPivot.transform.Rotate(0, hm, 0);

        }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
        m_Move = (v * m_CamForward + h * m_Cam.right) * walkSpeed;
        //m_Character.Move(m_Move);

        if (jump)
            {
            rb.velocity = new Vector3(m_Move.x, jumpForce, m_Move.z);
            }else
            {
            rb.velocity = new Vector3(m_Move.x, rb.velocity.y, m_Move.z);
            }
        



        //Input for Jump
        if (Input.GetKeyDown(KeyCode.Space))
            {
            jump = true;
            }else
            {
            jump = false;
            }
    }

}
