using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<Audio> _musicSounds;
    [SerializeField] private List<Audio> _sfxSounds;

    [SerializeField] private AudioSource _musicSource;
    [SerializeField] private AudioSource _sfxSource;

    public void PlayMusic(string name)
    {
        Audio sound = _musicSounds.Find(s => s.Name == name);

        if (sound != null)
        {
            _musicSource.clip = sound.Clip;
            _musicSource.Play();
        }
    }

    public void PlaySFX(string names)
    {
        string[] nameArray = names.Split(',');

        int randomIndex = Random.Range(0, nameArray.Length);
        string randomName = nameArray[randomIndex].Trim();

        Audio sound = _sfxSounds.Find(s => s.Name == randomName);

        if (sound != null)
        {
            _sfxSource.PlayOneShot(sound.Clip);
        }
    }
}