using System;

namespace SharedLogic {

    class TestProgram {
        public static void Main(string[] args) {
            Console.WriteLine("Main ran!");
        }

        public static void PrintTest() {
            Console.WriteLine("Hello SharedLogic World!");
        }
    }

    class Player {
        public float pos_x;
        public float pos_y;

        public Player(float x, float y) {
            pos_x = x;
            pos_y = y;
        }

        public void PrintPosition() {
            Console.WriteLine("Player position: " + pos_x + ", " + pos_y);
        }

        public static void main() {
            Console.WriteLine("Player Main ran!");
        }
    }
}