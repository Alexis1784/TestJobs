using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;
using Main;


namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        Number n1 = new Number(1);
        Number n2 = new Number(2);
        Number n3 = new Number(3);
        Number n4 = new Number(4);
        Number n_1 = new Number(-1);
        Number n_2 = new Number(-2);
        Number n_3 = new Number(-3);
        Number n_4 = new Number(-4);

        [TestMethod]
        public void AdditionTest()
        {    
            Addition add = new Addition(n1, n2);
            Assert.AreEqual(3, add.Eval());
            Assert.AreNotEqual(4, add.Eval());
            Addition addNeg = new Addition(n1, n_4);
            Assert.AreEqual(-3, addNeg.Eval());
            Assert.AreNotEqual(4, addNeg.Eval());
        }
         

        [TestMethod]
        public void SubtractionTest()
        {
            Subtraction sub = new Subtraction(n1, n2);
            Assert.AreEqual(-1, sub.Eval());
            Assert.AreNotEqual(4, sub.Eval());
            Subtraction minusOnMinus = new Subtraction(n1, n_4);
            Assert.AreEqual(5, minusOnMinus.Eval());
            Assert.AreNotEqual(-5, minusOnMinus.Eval());
        }

        [TestMethod]
        public void NegationTest()
        {
            Negation neg = new Negation(n1);
            Assert.AreEqual(-1, neg.Eval() );
            Assert.AreNotEqual(1, neg.Eval() );
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Multiplication mul = new Multiplication(n2, n4);
            Assert.AreEqual(8, mul.Eval());
            Assert.AreNotEqual(1.5, mul.Eval());
            Multiplication mulNeg = new Multiplication(n2, n_4);
            Assert.AreEqual(-8, mulNeg.Eval());
            Assert.AreNotEqual(0.5, mulNeg.Eval());
        }

        [TestMethod]
        public void DivisionTest()
        {
            Division div = new Division(n2, n4);
            Assert.AreEqual(0.5, div.Eval());
            Assert.AreNotEqual(1.5, div.Eval());
            Division divNeg = new Division(n2, n_4);
            Assert.AreEqual(-0.5, divNeg.Eval());
            Assert.AreNotEqual(0.5, divNeg.Eval());
        }

        [TestMethod]
        public void ToExpressionTwoOperandsTest()
        {
            Assert.AreEqual(10, new ToExpression("3+7").Calc());
            Assert.AreNotEqual(11, new ToExpression("3+7").Calc());
        }
        
        [TestMethod]
        public void ToExpressionAnyOperandsTest()
        {
            Assert.AreEqual(-7, new ToExpression("3+7-17").Calc() );
            Assert.AreNotEqual(7, new ToExpression("3+7-17").Calc() );
        }
        [TestMethod]
        public void ToExpressionWithParenthesesTest()
        {
            Assert.AreEqual(2, new ToExpression("(3+1)/2").Calc());
            Assert.AreNotEqual(3, new ToExpression("(3+1)/2").Calc() );
        }
        public void ToExpressionWithParenthesesAndNegativeNumbersTest()
        {
            Assert.AreEqual(-2, new ToExpression("(3+1)/(-2)").Calc());
            Assert.AreNotEqual(2, new ToExpression("(3+1)/(-2)").Calc());
            Assert.AreEqual(1, new ToExpression("(3-5)/(-2)").Calc());
            Assert.AreNotEqual(2, new ToExpression("(3-5)/(-2)").Calc());
        }
    }
}
