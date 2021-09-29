using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    /// <summary>
    /// ��ʾ go ����
    /// </summary>
    /// <param name="go">Ҫ��ʾ�Ĵ���</param>
    public void OnClickShowWindow(GameObject go)
    {
        go.SetActive(true);
    }

    /// <summary>
    /// ���� go ����
    /// </summary>
    /// <param name="go">Ҫ���صĴ���</param>
    public void OnClickHideWindow(GameObject go)
    {
        go.SetActive(false);
    }

    /// <summary>
    /// �л��� name ����
    /// </summary>
    /// <param name="name">��������</param>
    public void OnClickSwitchScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
