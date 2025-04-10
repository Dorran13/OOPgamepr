namespace _0407gamepr
{
    public class HomeScene : Scene
    {
        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;
        
        public HomeScene()
        {
            mapData = new string[]
            {
               "#########",
               "#       #",
               "#       #",
               "#       #",
               "#########"
            };

            map = new bool[5, 9];
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            Program.Player.position = new Vector2(4, 3);
            Program.Player.map = map;
        }
        public override void Render()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
            Program.Player.Print();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            Program.Player.Move(input);
        }
        public override void Result()
        {

        }
       
    }
}
