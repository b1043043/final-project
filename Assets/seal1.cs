using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class seal1 : ControlSea
{
    private static string playerName = ""; // 玩家名字（全局固定值）
    private static int luckyScore = 0;     // 幸運值（全局固定值）

    private GameObject dialoguePanel; // 對話面板
    private TMP_Text dialogueText;    // 對話文字
    private Button nextButton;        // 繼續按鈕
    private Button leaveButton;       // 離開按鈕
    private TMP_InputField inputField;// 玩家輸入框

    private enum DialogueState { None, Start, AskName, LuckyCheck, Options }
    private DialogueState state = DialogueState.None;

    void Start()
    {
        base.Start();

        // 自動尋找 UI 元素
        dialoguePanel = GameObject.Find("dialoguePanel");
        dialogueText = GameObject.Find("dialoguePanel/Text (TMP)").GetComponent<TMP_Text>();
        nextButton = GameObject.Find("dialoguePanel/NextButton").GetComponent<Button>();
        leaveButton = GameObject.Find("dialoguePanel/LeaveButton").GetComponent<Button>();
        inputField = GameObject.Find("dialoguePanel/InputField (TMP)").GetComponent<TMP_InputField>();

        dialoguePanel.SetActive(false); // 初始隱藏面板

        // 綁定按鈕事件
        nextButton.onClick.AddListener(OnContinue);
        leaveButton.onClick.AddListener(OnLeave);
    }

    public override void TriggerInteraction()
    {
        StartDialogue();
    }

    public void StartDialogue()
    {
        state = DialogueState.Start;
        dialoguePanel.SetActive(true);

        if (string.IsNullOrEmpty(playerName))
        {
            dialogueText.text = "你是誰？";
            inputField.gameObject.SetActive(false); // 初始隱藏輸入框
        }
        else
        {
            dialogueText.text = $"你好，{playerName}！我們又見面了。";
            state = DialogueState.LuckyCheck; // 直接跳到下一個階段
        }
    }

    public void OnContinue()
    {
        switch (state)
        {
            case DialogueState.Start:
                if (string.IsNullOrEmpty(playerName))
                {
                    state = DialogueState.AskName;
                    dialogueText.text = "我是...";
                    inputField.gameObject.SetActive(true); // 顯示輸入框
                }
                else
                {
                    state = DialogueState.LuckyCheck;
                    dialogueText.text = $"你好，{playerName}！我們又見面了。";
                }
                break;

            case DialogueState.AskName:
                // 獲取玩家輸入的名字
                playerName = inputField.text;
                dialogueText.text = $"{playerName}，這裡是哪？";
                inputField.gameObject.SetActive(false); // 隱藏輸入框
                state = DialogueState.LuckyCheck;
                break;

            case DialogueState.LuckyCheck:
                // 如果幸運值尚未骰出，進行骰點
                if (luckyScore == 0)
                {
                    luckyScore = Random.Range(3, 18)*5; // 骰 3d6
                }
                dialogueText.text = $"你骰出了 {luckyScore} 點幸運值！";
                state = DialogueState.Options;
                break;

            case DialogueState.Options:
                dialogueText.text = "你想一起散步嗎？游泳？還是吃魚？";
                break;

            default:
                dialogueText.text = "對話結束。";
                dialoguePanel.SetActive(false);
                break;
        }
    }

    public void OnLeave()
    {
        dialoguePanel.SetActive(false);
    }
}
