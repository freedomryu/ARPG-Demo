using UnityEngine;

public class UiPanelCtrl : MonoBehaviour
{
    /// <summary>
    /// CanvasGroup 元件本體
    /// </summary>
    private CanvasGroup _canvasGroup;
    /// <summary>
    /// 延遲載入CanvasGroup元件
    /// </summary>
    private CanvasGroup canvasGroup=> _canvasGroup ??= GetComponent<CanvasGroup>();
    [Tooltip("UI面板預設是否開啟")]
    public bool openOnAwake;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Switch(openOnAwake);
    }

    /// <summary>
    /// UI面板開關
    /// </summary>
    /// <param name="B">true 開 / flase 關</param>
    public void Switch(bool B)
    {
        
        canvasGroup.alpha = B ? 1 : 0;
        canvasGroup.blocksRaycasts = B;
    }

    #region 面板開關測試
    [ContextMenu("面板打開")]
    public void PanelOn()
    {
        Switch(true);
    }
    [ContextMenu("面板關閉")]
    public void PanelOff()
    {
        Switch(false);
    }
    #endregion 面板開關測試
}
