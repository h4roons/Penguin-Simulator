using UnityEngine;
using UnityEngine.UI;


public class MenuHandler : MonoBehaviour
{
    [SerializeField] GameObject[] Screens;
    public static int itemNo = 0;

    public void OnClick_MenuBtn(int val)
    {
        itemNo = val;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Screens.Length; i++)
        {  
            if (i == itemNo)
                Screens[i].SetActive(true);
            else
                Screens[i].SetActive(false);
        }
    }
}
