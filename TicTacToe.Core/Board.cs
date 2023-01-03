namespace TicTacToe.Core;

public class Board
{
    public int[,] Boxes { get; } = new int[3, 3];
    public int CurrentPlayer { get; private set; } = 1;
    public bool IsWin { get; private set; } = false;

    public void NewGame()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                Boxes[i, j] = 0;

        CurrentPlayer = 1;
        IsWin = false;

        InitBoard();
    }

    // return a status.
    // if IsWin == true : the game is ended with a winner.  restart the game
    // if Played box is != than 0.  the box is already played.  choose an other box.
    // if TestWin return true.  Current Win.
    public PlayBoxResult PlayBox(int x, int y)
    {
        if (IsWin)
            return PlayBoxResult.GameEnded;

        if (Boxes[x, y] != 0)
            return PlayBoxResult.Replay;

        Boxes[x, y] = CurrentPlayer;

        IsWin = TestWin(x, y);

        if (IsWin)
        {
            return PlayBoxResult.Win;
        }

        CurrentPlayer = CurrentPlayer % 2 + 1;

        if (TestDraw())
            return PlayBoxResult.Draw;

        return PlayBoxResult.GameContinue;
    }

    private bool TestWin(int x, int y) => TestV(x, y) == 3 || TestH(x, y) == 3 || TestD1(x, y) == 3 || TestD2(x, y) == 3;

    private bool TestDraw()
    {
        return false;
        throw new NotImplementedException();
    }

    private int TestH(int x, int y) => TestHPos(x, y) + TestHNeg(x, y) + 1;

    private int TestHPos(int x, int y)
    {
        if (x > Boxes.Length - 2)
            return 0;

        if (Boxes[x + 1, y] == CurrentPlayer)
            return TestHPos(x + 1, y) + 1;
        else
            return 0;
    }

    private int TestHNeg(int x, int y)
    {
        if (x < 1)
            return 0;

        if (Boxes[x - 1, y] == CurrentPlayer)
            return TestHNeg(x - 1, y) + 1;
        else
            return 0;
    }

    private int TestV(int x, int y) => TestVPos(x, y) + TestVNeg(x, y) + 1;

    private int TestVPos(int x, int y)
    {
        if (y > Boxes.GetLength(1) - 2)
        {
            return 0;
        }

        if (Boxes[x, y + 1] == CurrentPlayer)
        {
            return TestVPos(x, y + 1) + 1;
        }
        else
        {
            return 0;
        }
    }

    private int TestVNeg(int x, int y)
    {
        if (y < 1)
        {
            return 0;
        }

        if (Boxes[x, y - 1] == CurrentPlayer)
        {
            return TestVNeg(x, y - 1) + 1;
        }
        else
        {
            return 0;
        }
    }

    private int TestD1(int x, int y) => TestD1Pos(x, y) + TestD1Neg(x, y) + 1;

    private int TestD1Pos(int x, int y)
    {
        if (y > Boxes.GetLength(1) - 2 || x > Boxes.Length - 2)
        {
            return 0;
        }

        if (Boxes[x + 1, y + 1] == CurrentPlayer)
        {
            return TestD1Pos(x + 1, y + 1) + 1;
        }
        else
        {
            return 0;
        }
    }

    private int TestD1Neg(int x, int y)
    {
        if (y < 1 || x < 1)
        {
            return 0;
        }

        if (Boxes[x - 1, y - 1] == CurrentPlayer)
        {
            return TestD1Neg(x - 1, y - 1) + 1;
        }
        else
        {
            return 0;
        }
    }

    private int TestD2(int x, int y) => TestD2Pos(x, y) + TestD2Neg(x, y) + 1;

    private int TestD2Pos(int x, int y)
    {
        if (y < 1 || x > Boxes.Length - 2)
        {
            return 0;
        }

        if (Boxes[x + 1, y - 1] == CurrentPlayer)
        {
            return TestD2Pos(x + 1, y - 1) + 1;
        }
        else
        {
            return 0;
        }
    }

    private int TestD2Neg(int x, int y)
    {
        if (y > Boxes.GetLength(1) - 2 || x < 1)
        {
            return 0;
        }

        if (Boxes[x - 1, y + 1] == CurrentPlayer)
        {
            return TestD2Neg(x - 1, y + 1) + 1;
        }
        else
        {
            return 0;
        }
    }

    private void InitBoard()
    {
        const string msg = $"{nameof(InitBoard)} called.";

        Console.WriteLine(msg);
    }

    private void PlaceSymbol(int x, int y, int player)
    {
        string msg = $"{nameof(PlaceSymbol)}({x}, {y}, {player}) called.";

        Console.WriteLine(msg);
    }
}
