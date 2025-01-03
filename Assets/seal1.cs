using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class seal1 : ControlSea
{
    private static string playerName = ""; // ���a�W�r�]�����T�w�ȡ^
    private static int luckyScore = 0;     // ���B�ȡ]�����T�w�ȡ^

    private GameObject dialoguePanel; // ��ܭ��O
    private TMP_Text dialogueText;    // ��ܤ�r
    private Button nextButton;        // �~����s
    private Button leaveButton;       // ���}���s
    private TMP_InputField inputField;// ���a��J��

    private enum DialogueState { None, Start, AskName, LuckyCheck, Options }
    private DialogueState state = DialogueState.None;

    void Start()
    {
        base.Start();

        // �۰ʴM�� UI ����
        dialoguePanel = GameObject.Find("dialoguePanel");
        dialogueText = GameObject.Find("dialoguePanel/Text (TMP)").GetComponent<TMP_Text>();
        nextButton = GameObject.Find("dialoguePanel/NextButton").GetComponent<Button>();
        leaveButton = GameObject.Find("dialoguePanel/LeaveButton").GetComponent<Button>();
        inputField = GameObject.Find("dialoguePanel/InputField (TMP)").GetComponent<TMP_InputField>();

        dialoguePanel.SetActive(false); // ��l���í��O

        // �j�w���s�ƥ�
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
            dialogueText.text = "�A�O�֡H";
            inputField.gameObject.SetActive(false); // ��l���ÿ�J��
        }
        else
        {
            dialogueText.text = $"�A�n�A{playerName}�I�ڭ̤S�����F�C";
            state = DialogueState.LuckyCheck; // ��������U�@�Ӷ��q
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
                    dialogueText.text = "�ڬO...";
                    inputField.gameObject.SetActive(true); // ��ܿ�J��
                }
                else
                {
                    state = DialogueState.LuckyCheck;
                    dialogueText.text = $"�A�n�A{playerName}�I�ڭ̤S�����F�C";
                }
                break;

            case DialogueState.AskName:
                // ������a��J���W�r
                playerName = inputField.text;
                dialogueText.text = $"{playerName}�A�o�̬O���H";
                inputField.gameObject.SetActive(false); // ���ÿ�J��
                state = DialogueState.LuckyCheck;
                break;

            case DialogueState.LuckyCheck:
                // �p�G���B�ȩ|����X�A�i����I
                if (luckyScore == 0)
                {
                    luckyScore = Random.Range(3, 18)*5; // �� 3d6
                }
                dialogueText.text = $"�A��X�F {luckyScore} �I���B�ȡI";
                state = DialogueState.Options;
                break;

            case DialogueState.Options:
                dialogueText.text = "�A�Q�@�_���B�ܡH��a�H�٬O�Y���H";
                break;

            default:
                dialogueText.text = "��ܵ����C";
                dialoguePanel.SetActive(false);
                break;
        }
    }

    public void OnLeave()
    {
        dialoguePanel.SetActive(false);
    }
}
