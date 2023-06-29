using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float flipInterval = 0.5f;

    private float timer;
    private readonly bool isFlipped = false;

    private void Update()
    {
        // ��������� ��������� �������
        timer += Time.deltaTime;

        // ��������, �� ��������� ���������
        if (timer >= flipInterval)
        {
            // ���� ����
            spriteRenderer.flipX = !spriteRenderer.flipX;

            // �������� �������
            timer = 0f;
        }
    }
}
