global using Raylib_cs;

Raylib.InitWindow(800, 600, "ProjectName");
Raylib.SetTargetFPS(60);

Character myChar = new Character();

while (!Raylib.WindowShouldClose())
{
    //LOGIK

    //GRAFIK
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    myChar.Draw();

    Raylib.EndDrawing();
}