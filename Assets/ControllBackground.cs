/*
 * https://tech.pjin.jp/blog/2017/04/18/unity_background_scroll/
 */

using UnityEngine;

/// <summary>
/// �y�w�i�̃R���g���[���p�N���X�z
///     �w�i��3���A�J�������猩�؂ꂽ���荞��
/// </summary>
public class ControllBackground : MonoBehaviour
{

    // �w�i�̖���
    int spriteCount = 3;
    // �w�i����荞��
    float rightOffset = 1.45f;
    float leftOffset = -0.4f;

    Transform bgTfm;
    SpriteRenderer mySpriteRndr;
    float width;

    void Start()
    {
        bgTfm = transform;
        mySpriteRndr = GetComponent<SpriteRenderer>();
        width = mySpriteRndr.bounds.size.x;
    }


    void Update()
    {
        // ���W�ϊ�
        Vector3 myViewport = Camera.main.WorldToViewportPoint(bgTfm.position);

        // �w�i�̉�荞��(�J������X���v���X�����Ɉړ���)
        if (myViewport.x < leftOffset)
        {
            bgTfm.position += Vector3.right * (width * spriteCount);
        }
        // �w�i�̉�荞��(�J������X���}�C�i�X�����Ɉړ���)
        else if (myViewport.x > rightOffset)
        {
            bgTfm.position -= Vector3.right * (width * spriteCount);
        }
    }
}
