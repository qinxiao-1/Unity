using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    /// <summary>
    /// 显示 go 窗口
    /// </summary>
    /// <param name="go">要显示的窗口</param>
    public void OnClickShowWindow(GameObject go)
    {
        go.SetActive(true);
    }

    /// <summary>
    /// 隐藏 go 窗口
    /// </summary>
    /// <param name="go">要隐藏的窗口</param>
    public void OnClickHideWindow(GameObject go)
    {
        go.SetActive(false);
    }

    /// <summary>
    /// 切换到 name 场景
    /// </summary>
    /// <param name="name">场景名称</param>
    public void OnClickSwitchScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
