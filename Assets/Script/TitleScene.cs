using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// タイトルシーンの制御。
/// </summary>
public class TitleScene : MonoBehaviour {

    /// <summary>
    /// ボタンが押されたときの効果音
    /// </summary>
    public AudioClip seButton;

    /// <summary>
    /// 宣伝用の URL です。
    /// この企画の連載記事の URL を設定しています。
    /// </summary>
    public string urlCM = "http://blog.item-store.net/entry/2017/12/14/101613";

    private void Awake()
    {
    }
    private void OnDestroy()
    {
    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
		
	}

    /// <summary>
    /// このアプリ開発の連載記事の宣伝用。
    /// </summary>
    public void OnButtonSiteUrlButton()
    {
        // 効果音を再生
        Util.PlayAudioClip(this.seButton, Camera.main.transform.position, 1.0f);
        // 連載記事のサイトを開きます。
        Util.OpenURL(this.urlCM);
    }

    /// <summary>
    /// プレイヤー情報の初期化を行います。
    /// ステージの状態が初期化されます。
    /// デバッグ専用。
    /// </summary>
    public void OnDebugButtonPlayerPrefsClear()
    {
        // 効果音を再生
        Util.PlayAudioClip(this.seButton, Camera.main.transform.position, 1.0f);
        // このアプリの PlayerPrefs の設定を全て消去します。
        PlayerPrefs.DeleteAll();
    }
}
