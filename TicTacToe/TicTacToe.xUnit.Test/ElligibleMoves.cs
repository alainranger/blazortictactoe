using TicTacToe.Core;

namespace TicTacToeTest.XUnit;

public class ElligibleMoves
{
    [Fact]
    public void EllibileMoves_IsUserInputValidMove_Returns()
    {
        Board board = new();

        var result = board.PlayBox(0, 0);

        int[,] expectedBox = { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        Assert.Equal(expectedBox, board.Boxes);
        Assert.Equal(PlayBoxResult.GameContinue, result);
    }

    [Fact]
    public void Test2()
    {
        Board board = new();

        var moves = new[]
        {
            new { x = 0, y = 0, expectedReturn = false },
            new { x = 0, y = 0, expectedReturn = false },
        };

        moves.ToList().ForEach(move =>
        {
            var result = board.PlayBox(move.x, move.y);

        });

        int[,] expectedBox = { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        Assert.Equal(expectedBox, board.Boxes);
    }
}
