using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button startButton;
    public Animator buttonAnimator;
    public RectTransform panel;
    public TextMeshProUGUI resultText;
    public ParticleSystem effect;

    private void Start()
    {
        // ��� �ؽ�Ʈ�� ó���� �Ⱥ��̰�
        resultText.color = new Color(1, 1, 1, 0);

        // ��ư Ŭ�� �� ���� ����
        startButton.onClick.AddListener(OnStartClicked);
    }

    void OnStartClicked()
    {
        // 1. Animator ���� (��ư ���� �ִϸ��̼�)
        buttonAnimator.SetTrigger("Click");

        // 2. DOTween���� �г� �̵�
        panel.anchoredPosition = new Vector2(-800, 0); // ���ʿ��� ����
        panel.DOAnchorPos(Vector2.zero, 1f).SetEase(Ease.OutBounce);

        // 4. ��� �ؽ�Ʈ ���̵� ��
        resultText.DOFade(1f, 2f).SetDelay(2.5f);

        // 3. ��ƼŬ ȿ�� ����
        effect.Play();

       
    }
}
