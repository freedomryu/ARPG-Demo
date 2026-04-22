using UnityEngine;
using Unity.Cinemachine;

public class UIPlayerSelectCtrl : MonoBehaviour
{
    /// <summary>
    /// 索引原始值
    /// </summary>
    private int _index;

    private int index
    {
        get { return _index; }
        set 
        { 
            _index = value < 0 ? vCams.Length - 1 : value % vCams.Length; 
        }
    }

    public CinemachineCamera[] vCams;

    public void NextPlayer()
    {
        vCams[index].Priority.Enabled = false;
        index++;    //索引增加
        vCams[index].Priority.Enabled = true;
    }

    public void PrevPlayer()
    {
        vCams[index].Priority.Enabled = false;
        index--;    //索引減少
        vCams[index].Priority.Enabled = true;
    }
}
