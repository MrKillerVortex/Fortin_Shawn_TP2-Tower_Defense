using UnityEngine;
using UnityEngine.UI;
public class Continue : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ToggleResume);
    }
    public void ToggleResume()
    {
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
    }
}
