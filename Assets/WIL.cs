using UnityEngine;
using TMPro; // 引入 TextMeshPro 命名空間

public class WIL : MonoBehaviour
{
    private TMP_Text wil;

    void Start()
    {
        // 獲取當前物件上的 TextMeshPro - Text 組件
        wil = GetComponent<TMP_Text>();
        wil.enabled = false; // 隱藏文字
    }

    void Update()
    {

    }

    public void showwil()
    {
        wil.enabled = true; // 顯示文字
    }
}
