/*
 * https://www.sejuku.net/blog/56265 how to envoke click event
 * https://your-3d.com/unity-instantiate-obj/ how to make instance
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject _box;
    public Camera _camera;

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        Vector3 tmp = _camera.transform.position;
        float x = tmp.x;

        //Debug.Log("押された!");  // ログを出力
        Instantiate(_box, new Vector3(x, 0, 21.7f), Quaternion.identity);
    }
}