using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace TicTacToeTests
{
    [TestClass]
    public class TicTacToeTest
    {
        

        [TestMethod]

        public void TestFields()
        {
            try
            {
                TicTacToe.CreateBoard();

                for (int i = 1; i <= 9; i++)
                    TicTacToe.MakeMove(i.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CurrentPlayerX()
        {
            TicTacToe.player = 1;
            char curr = TicTacToe.CurrentPlayer();

            if (curr != 'X')
                throw new Exception();
        }

        public void CurrentPlayerO()
        {
            TicTacToe.player = 0;
            char curr = TicTacToe.CurrentPlayer();

            if (curr != 'O')
                throw new Exception();
        }

        public void MakeMoveX()
        {
            TicTacToe.player = 1;
            try
            {
                TicTacToe.CreateBoard();
                TicTacToe.MakeMove("1");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MakeMoveO()
        {
            TicTacToe.player = 1;
            try
            {
                TicTacToe.CreateBoard();
                TicTacToe.MakeMove("1");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SpaceNotInUse()
        {
            TicTacToe.CreateBoard();
            if (!TicTacToe.SpaceInUse(1))
                TicTacToe.MakeMove("1");
        }
    }
}
