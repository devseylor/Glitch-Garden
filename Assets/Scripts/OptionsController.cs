using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.8f;
    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultDifficulty = 1f;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefController.GetMasterVolume();

        difficultySlider.value = PlayerPrefController.GetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found... did you start from splash screen?");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefController.SetMasterVolume(volumeSlider.value);
        PlayerPrefController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().LoadMainManu();
    }
    
    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }
}
