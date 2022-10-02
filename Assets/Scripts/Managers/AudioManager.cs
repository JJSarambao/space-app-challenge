using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region SINGLETON

    private static AudioManager _Instance;
    public static AudioManager Instance
    {
        get
        {
            if (_Instance == null)
                _Instance = GameObject.FindObjectOfType<AudioManager>();

            return _Instance;
        }
    }

    #endregion

    public AudioSource audioSource;
    public Audios[] audioList;

    [System.Serializable]
    public class Audios
    {
        public string name;
        public AudioClip audio;
    }

    public void PlayAudio(string name)
    {
        for (int i = 0; i < audioList.Length; i++)
        {
            if (audioList[i].name.Equals(name))
            {
                audioSource.clip = audioList[i].audio;
                audioSource.Play();
            }
        }
    }

}
