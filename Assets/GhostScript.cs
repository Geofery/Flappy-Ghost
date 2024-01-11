using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public LogicScript logicScript;
    public AudioManager audioManager;
    public bool ghostIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ghostIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
            audioManager.PlaySFX(audioManager.flap);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioManager.PlaySFX(audioManager.collision);
        gameObject.SetActive(false);
        logicScript.gameOver();
        ghostIsAlive = false;
    }

}
