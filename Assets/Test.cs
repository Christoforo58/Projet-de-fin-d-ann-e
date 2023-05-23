using UnityEngine;

public class ImageShow : MonoBehaviour
{
    [SerializeField]
    public GameObject obj;
    void Start()
    {
        this.gameObject.SetActive(false);
    }
    void Update()
    {

    }
}
