namespace TicTacToe.xUnit.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}


/*
public class UnitTest1
{
    private Board _board = new Board();

    [SetUp]
    public void Setup()
    {
        _board.NewGame();
    }

    [Test]
    public void Test1()
    {
        bool isWin = _board.PlayBox(0, 0);

        int[,] expectedBox = { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        Assert.That(_board.Boxes, Is.EqualTo(expectedBox));
        Assert.IsFalse(isWin);
    }

    [Test]
    public void Test2()
    {
        var moves = new[]
        {
            new { x = 0, y = 0, expectedReturn = false },
            new { x = 0, y = 0, expectedReturn = false },
        };

        moves.ToList().ForEach(move =>
        {
            bool result = _board.PlayBox(move.x, move.y);

        });

        int[,] expectedBox = { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        Assert.That(_board.Boxes, Is.EqualTo(expectedBox));
    }
} 
*/