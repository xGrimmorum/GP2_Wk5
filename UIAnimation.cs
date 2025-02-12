using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    [SerializeField] private Animator UIPanel;
    [SerializeField] private Animator StagePanel;


    public void StageSelected()
    {
        UIPanel.SetTrigger("Started");
    }

    public void StageAnimation()
    {
        StagePanel.SetTrigger("Stage");
    }
}
