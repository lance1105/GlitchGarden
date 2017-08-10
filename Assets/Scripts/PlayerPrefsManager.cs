using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    // Interface for talking to playerprefs in a nice manner
    // Will keep tabs on the 

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";
    // level_unlocked_1 ex.


    #region Volume
    public static void SetMasterVolume(float volume) {
        if (volume > 0f && volume < 1f) {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        } else {
            Debug.LogError("Master volume out of range");
        }
    }

    public static float GetMasterVolume() {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    #endregion

    #region Level Unlock
    public static void UnlockLevel(int level) {
        if (level <= Application.levelCount - 1) {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // use 1 for true
        } else {
            Debug.LogError("Trying to unlock nonexisting level");
        }
    }


    public static bool IsLevelUnlocked(int level) {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level);
        bool isLevelUnlocked = (levelValue == 1);

        if (level <= Application.levelCount - 1) {
            return isLevelUnlocked;

        } else {
            Debug.LogError("Trying to unlock nonexisting level");
            return false;
        }

    }
    #endregion

    #region Difficulty
    public static void SetDifficulty(float difficulty) {
        if (difficulty >= 0f && difficulty <= 1f) {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        } else {
            Debug.LogError("Trying to set invalid difficulty");
        }
    }

    public static float GetDifficulty() {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
    #endregion
}
