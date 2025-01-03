using UnityEngine;
using TMPro; // 引入 TextMeshPro 命名空間

public class EDU : MonoBehaviour
{
    private TMP_Text edu;

    void Start()
    {
        // 獲取當前物件上的 TextMeshPro - Text 組件
        edu = GetComponent<TMP_Text>();
        edu.enabled = false; // 隱藏文字
    }

    void Update()
    {

    }

    public void showedu()
    {
        edu.enabled = true; // 顯示文字
    }
}
