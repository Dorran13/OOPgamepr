namespace _0407gamepr
{
    internal class Program
    {
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        private static Player player;

        public static Player Player { get { return player; } }

        private static bool gameOver;
        static void Main(string[] args) 
        {
            Start();

            Run();

            End();
        }

        static void Start()
        {
            Console.CursorVisible = false;

            gameOver = false;

            player = new Player();

            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Home", new HomeScene());
            //sceneDic.Add("Battle", new BattleScene());
            //sceneDic.Add("Shop", new ShopScene());
            //sceneDic.Add("Field", new FieldScene());

            Console.WriteLine("***********************************");
            Console.WriteLine("* 간단한 텍스트 기반 턴제전투게임 *");
            Console.WriteLine("***********************************");
            Console.WriteLine();
            Console.WriteLine("아무키나 누르시면 시작합니다");

            Console.ReadKey(true);

            

            Program.ChangeScene("Home");

            
        }
        public static void Run()
        {
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

        }

        static void End()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("* 축하드립니다 게임을 클리어 하셨습니다! *");
            Console.WriteLine("******************************************");
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }
    }
}
