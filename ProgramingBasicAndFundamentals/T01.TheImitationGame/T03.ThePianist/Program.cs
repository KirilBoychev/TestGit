using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Pieces> pieces = new List<Pieces>();

            for (int i = 0; i < n; i++)
            {
                string[] inputPiece = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string namePiece = inputPiece[0];
                string composer = inputPiece[1];
                string key = inputPiece[2];

                Pieces currOne = new Pieces(namePiece, composer, key);
                pieces.Add(currOne);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArr = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArr[0] == "Add")
                {
                    Pieces currOne = new Pieces(commandArr[1], commandArr[2], commandArr[3]);

                    if (!pieces.Any(x => x.Piece == commandArr[1]))
                    {
                        pieces.Add(currOne);
                        Console.WriteLine($"{currOne.Piece} by {currOne.Composer} in {currOne.Key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{currOne.Piece} is already in the collection!");
                    }
                }
                else if (commandArr[0] == "Remove")
                {
                    if (!pieces.Any(x => x.Piece == commandArr[1]))
                    {
                        Console.WriteLine($"Invalid operation! {commandArr[1]} does not exist in the collection.");

                    }
                    foreach (var piece in pieces.Where(x => x.Piece == commandArr[1]).ToList())
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece.Piece}!");
                    }
                }
                else if (commandArr[0] == "ChangeKey")
                {
                    if (!pieces.Any(x => x.Piece == commandArr[1]))
                    {
                        Console.WriteLine($"Invalid operation! {commandArr[1]} does not exist in the collection.");

                    }
                    foreach (var piece in pieces.Where(x => x.Piece == commandArr[1]).ToList())
                    {
                        piece.Key = commandArr[2];
                        Console.WriteLine($"Changed the key of {piece.Piece} to {piece.Key}!");
                        continue;
                    }
                }
            }

            foreach (var pie in pieces)
            {
                Console.WriteLine($"{pie.Piece} -> Composer: {pie.Composer}, Key: {pie.Key}");
            }
        }
    }

    class Pieces
    {
        public Pieces(string piece, string composer, string key)
        {
            this.Piece = piece;
            this.Composer = composer;
            this.Key = key;
        }
        public string Piece { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
