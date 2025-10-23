using UnityEngine;

public class Menuchanger : MonoBehaviour

{
    public GameObject videoPanel;
    public GameObject mathpanel;
    public GameObject madpanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeThat (string nameOfPanel)
    {
        videoPanel.SetActive(nameOfPanel == "video");
        mathpanel.SetActive(nameOfPanel == "math");
        madpanel.SetActive(nameOfPanel == "mad");
    }

}
