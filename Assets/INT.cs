using UnityEngine;
using TMPro; // 引入 TextMeshPro 命名空間

public class INT : MonoBehaviour
{
    public int a = 0; // 計數
    private TMP_Text Int; 

    void Start()
    {
        // 獲取當前物件上的 TextMeshPro - Text 組件
        Int = GetComponent<TMP_Text>();
        Int.enabled = false; // 隱藏文字
    }

    void Update()
    {
        
    }

    public virtual void showInt()
    {
        Int.enabled = true; // 顯示文字
    }
}
