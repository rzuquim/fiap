public partial class Walls
{
    private void Spawn()
    {
        var cam = Camera.main;

        var height = cam.orthographicSize * 2f;
        var width = height * cam.aspect;

        var x = width / 2f;
        var y = height / 2f;

        CreateWall(
            "TopWall",
            new Vector2(0, y + _wallThickness / 2),
            new Vector2(width + _wallThickness * 2, _wallThickness)
        );

        CreateWall(
            "BottomWall",
            new Vector2(0, -y - _wallThickness / 2),
            new Vector2(width + _wallThickness * 2, _wallThickness)
        );

        CreateWall(
            "LeftWall",
            new Vector2(x - _wallThickness / 2, 0),
            new Vector2(_wallThickness, height + _wallThickness * 2)
        );

        CreateWall(
            "RightWall",
            new Vector2(-x + _wallThickness / 2, 0),
            new Vector2(_wallThickness, height + _wallThickness * 2)
        );
    }

    void CreateWall(string name, Vector2 pos, Vector2 size)
    {
        Debug.Log($"Spawning wall {name} @ {pos} x {size}");
        var wall = new GameObject(name);
        wall.transform.parent = transform;
        wall.transform.position = pos;

        var collider = wall.AddComponent<BoxCollider2D>();
        collider.size = size;
    }
}
