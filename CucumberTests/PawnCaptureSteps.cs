using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class PawnCaptureSteps
    {


        public PawnCaptureSteps(PawnMovementSteps p)
        {
            moveSteps = p;
        }


        Pawn blackPawn = null;
        private PawnMovementSteps moveSteps;

        [Given(@"I have a black pawn at (.)(.)")]
        public void GivenIHaveABlackPawnAtE(char x, int y)
        {
            blackPawn = new Pawn("black");
            moveSteps.board.placePiece(blackPawn, new Tuple<char, int>(x, y));
        }
        
        [Then(@"the black pawn is captured")]
        public void ThenTheBlackPawnIsCaptured()
        {
            Assert.IsTrue(blackPawn.isCaptured());
        }
    }
}
