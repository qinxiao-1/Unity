using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    /// <summary>
    /// 视频切换
    /// </summary>
    /// <param name="videoClip">切换的目标视频</param>
    public void ChangeVideo(VideoClip videoClip)
    {
        videoPlayer.clip = videoClip;
        // 解决切换视频时卡上个视频一帧的问题
        videoPlayer.targetTexture.Release();
        videoPlayer.targetTexture.MarkRestoreExpected();
    }
}
