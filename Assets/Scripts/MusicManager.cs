using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;


    void Awake() {
        // Make this object persistent through every level, therefore do not
        // destroy it when changing scenes.
        DontDestroyOnLoad(this);

    }

    private void Start() {
        // Get the audio source component from the object
        audioSource = this.GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level) {


        AudioClip levelMusic = levelMusicChangeArray[level];

        if (levelMusic) {
            audioSource.clip = levelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }


    }



}
