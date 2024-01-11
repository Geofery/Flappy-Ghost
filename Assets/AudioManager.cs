using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------- Audio Source --------")]
    [SerializeField] AudioSource backgroundSource;
    [SerializeField] AudioSource sfxSource;

    [Header("--------- Audio Clip --------")]
    public AudioClip background;
    public AudioClip collision;
    public AudioClip flap;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        backgroundSource.clip = background;
        backgroundSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}



    /*private void Awake()
    {
        GameObject[] musicObject = GameObject.FindGameObjectsWithTag("Music");

        if (musicObject.Length > 1 )
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }*/
