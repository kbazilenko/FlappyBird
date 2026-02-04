using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject Menu;

    public void OpenMenu()
    {
        Menu.SetActive(true);
    }
}
