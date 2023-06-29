using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float flipInterval = 0.5f;

    private float timer;
    private readonly bool isFlipped = false;

    private void Update()
    {
        // «б≥льшенн€ л≥чильника таймера
        timer += Time.deltaTime;

        // ѕерев≥рка, чи дос€гнуто ≥нтервалу
        if (timer >= flipInterval)
        {
            // «м≥на фл≥пу
            spriteRenderer.flipX = !spriteRenderer.flipX;

            // —киданн€ таймера
            timer = 0f;
        }
    }
}
