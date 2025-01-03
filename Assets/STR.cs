using UnityEngine;
using TMPro; // 引入 TextMeshPro 命名空間

public class STR : MonoBehaviour
{
    private TMP_Text str;

    void Start()
    {
        // 獲取當前物件上的 TextMeshPro - Text 組件
        str = GetComponent<TMP_Text>();
        str.enabled = false; // 隱藏文字
    }

    void Update()
    {

    }

    public void showluk()
    {
        str.enabled = true; // 顯示文字
    }
}
