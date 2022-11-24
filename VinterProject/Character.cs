public class Character
{
    private Rectangle rect;

    public Character()
    {
        rect = new Rectangle(0, 0, 32, 32);
    }
    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.GREEN);
    }
}
