using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    public float fadeInTime;

    private Image fadePanel;

    private Color currentColor = Color.black;

    // Use this for initialization
    void Start() {
        this.fadePanel = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update() {
        if (Time.timeSinceLevelLoad < fadeInTime) {
            // something
            float alphaChange = Time.deltaTime / this.fadeInTime;
            this.currentColor.a -= alphaChange;
            this.fadePanel.color = this.currentColor;
        } else {
            this.gameObject.SetActive(false);
        }
    }
}
