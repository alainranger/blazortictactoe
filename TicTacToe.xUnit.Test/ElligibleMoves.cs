using TicTacToe.Core;

namespace TicTacToeTest.XUnit;

public class ElligibleMoves
{
    private Board _board;

    public ElligibleMoves()
    {
        _board = new();
    }

    [Fact]
    public void Player_PlayBox_Return_GameContinue()
    {
        var inputs = Get_Player_PlayBox_Return_Win_Inputs();

        inputs.ToList().ForEach(input =>
        {
            var result = _board.PlayBox(input.X, input.Y);

            Assert.Equal(input.ExpectedBoxes, _board.Boxes);
            Assert.Equal(input.ExpectedResult, result);
        });
    }

    [Fact]
    public void Player_PlayBox_Return_Win()
    {
        var inputs = Get_Player_PlayBox_Return_Win_Inputs();

        inputs.ToList().ForEach(input =>
        {
            var result = _board.PlayBox(input.X, input.Y);

            Assert.Equal(input.ExpectedBoxes, _board.Boxes);
            Assert.Equal(input.ExpectedResult, result);
        });
    }

    [Fact]
    public void Player_PlayBox_Return_Replay()
    {
        var inputs = GET_Player_PlayBox_Return_Replay_Inputs();

        inputs.ToList().ForEach(input =>
        {
            var result = _board.PlayBox(input.X, input.Y);

            Assert.Equal(input.ExpectedBoxes, _board.Boxes);
            Assert.Equal(input.ExpectedResult, result);
        });
    }

    [Fact]
    public void Player_PlayBox_Return_GameEnded()
    {
        var inputs = GET_Player_PlayBox_Return_GameEnded_Inputs();

        inputs.ToList().ForEach(input =>
        {
            var result = _board.PlayBox(input.X, input.Y);

            Assert.Equal(input.ExpectedBoxes, _board.Boxes);
            Assert.Equal(input.ExpectedResult, result);
        });
    }

    [Fact]
    public void Player_PlayBox_Return_Draw()
    {
        var inputs = GET_Player_PlayBox_Return_Draw_Inputs();

        inputs.ToList().ForEach(input =>
        {
            var result = _board.PlayBox(input.X, input.Y);

            Assert.Equal(input.ExpectedBoxes, _board.Boxes);
            Assert.Equal(input.ExpectedResult, result);
        });
    }

    private struct PlayerInput
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int[,] ExpectedBoxes { get; set; }
        public PlayBoxResult ExpectedResult { get; set; }
    }

    private PlayerInput[] Get_Player_PlayBox_Return_Win_Inputs() => new PlayerInput[]
    {
        new PlayerInput
        {
            X = 0, Y = 0,
            ExpectedBoxes = new [,]
            {
                { 1, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            }, ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 1,
            Y = 0,
            ExpectedBoxes = new[,]
            {
                { 1, 0, 0 },
                { 2, 0, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 0,
            Y = 1,
            ExpectedBoxes = new[,]
            {
                { 1, 1, 0 },
                { 2, 0, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 1,
            Y = 1,
            ExpectedBoxes = new[,]
            {
                { 1, 1, 0 },
                { 2, 2, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 0,
            Y = 2,
            ExpectedBoxes = new[,]
            {
                { 1, 1, 1 },
                { 2, 2, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.Win
        },
    };

    private PlayerInput[] Get_Player_PlayBox_Return_GameContinue_Inputs() => new PlayerInput[]
    {
        new PlayerInput
        {
            X = 0, Y = 0,
            ExpectedBoxes = new [,]
            {
                { 1, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        }
    };

    private PlayerInput[] GET_Player_PlayBox_Return_Replay_Inputs() => new PlayerInput[]
    {
        new PlayerInput
        {
            X = 0, Y = 0,
            ExpectedBoxes = new [,]
            {
                { 1, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 0, Y = 0,
            ExpectedBoxes = new [,]
            {
                { 1, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.Replay
        }
    };

    private PlayerInput[] GET_Player_PlayBox_Return_GameEnded_Inputs() => new PlayerInput[]
    {
        new PlayerInput
        {
            X = 0, Y = 0,
            ExpectedBoxes = new [,]
            {
                { 1, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            }, ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 1,
            Y = 0,
            ExpectedBoxes = new[,]
            {
                { 1, 0, 0 },
                { 2, 0, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 0,
            Y = 1,
            ExpectedBoxes = new[,]
            {
                { 1, 1, 0 },
                { 2, 0, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 1,
            Y = 1,
            ExpectedBoxes = new[,]
            {
                { 1, 1, 0 },
                { 2, 2, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        },
        new PlayerInput
        {
            X = 0,
            Y = 2,
            ExpectedBoxes = new[,]
            {
                { 1, 1, 1 },
                { 2, 2, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.Win
        },
        new PlayerInput
        {
            X = 1,
            Y = 2,
            ExpectedBoxes = new[,]
            {
                { 1, 1, 1 },
                { 2, 2, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameEnded
        }
    };

    private PlayerInput[] GET_Player_PlayBox_Return_Draw_Inputs() => new PlayerInput[]
    {
        new PlayerInput
        {
            X = 0, Y = 0,
            ExpectedBoxes = new [,]
            {
                { 1, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            },
            ExpectedResult = PlayBoxResult.GameContinue
        }
    };
}
