using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignAudio : MonoBehaviour {


    private enum State
    {
        Idle,
        Focused,
        Clicked,
        Approaching,
        Moving,
        Collect,
        Collected,
        Occupied,
        Open,
        Hidden
    }


    [Header("Sounds")]
    public AudioClip clip_click = null;

    private State _state = State.Idle;
    private AudioSource _audio_source = null;

    // Use this for initialization
    void Start () {
   

}


    void Awake()
    {
        _audio_source = gameObject.GetComponent<AudioSource>();
        _audio_source.clip = clip_click;
        _audio_source.playOnAwake = false;
    }

    // Update is called once per frame
    void Update ()
    {
       
    }

    public void Click()
    {
        _state = _state == State.Focused ? State.Clicked : _state;

        _audio_source.Play();

    }

}
