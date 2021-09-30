using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    /// <summary>
    /// ��Ƶ�л�
    /// </summary>
    /// <param name="videoClip">�л���Ŀ����Ƶ</param>
    public void ChangeVideo(VideoClip videoClip)
    {
        videoPlayer.clip = videoClip;
        // ����л���Ƶʱ���ϸ���Ƶһ֡������
        videoPlayer.targetTexture.Release();
        videoPlayer.targetTexture.MarkRestoreExpected();
    }
}
