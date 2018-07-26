using Sirenix.OdinInspector;
using UnityEngine;

public class ActivateOnButtonPress : MonoBehaviour
{
    [Required] [SerializeField] GameObject ObjectToActivate;
    [SerializeField] KeyCode KeyToPress = KeyCode.Space;

    private void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            ObjectToActivate.SetActive(true);
        }   
    }
}
