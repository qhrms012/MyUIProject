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
        // 결과 텍스트는 처음에 안보이게
        resultText.color = new Color(1, 1, 1, 0);

        // 버튼 클릭 시 연출 시작
        startButton.onClick.AddListener(OnStartClicked);
    }

    void OnStartClicked()
    {
        // 1. Animator 실행 (버튼 눌림 애니메이션)
        buttonAnimator.SetTrigger("Click");

        // 2. DOTween으로 패널 이동
        panel.anchoredPosition = new Vector2(-800, 0); // 왼쪽에서 시작
        panel.DOAnchorPos(Vector2.zero, 1f).SetEase(Ease.OutBounce);

        // 4. 결과 텍스트 페이드 인
        resultText.DOFade(1f, 2f).SetDelay(2.5f);

        // 3. 파티클 효과 실행
        effect.Play();

       
    }
}
