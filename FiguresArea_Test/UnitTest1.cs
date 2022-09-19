using FiguresArea;

namespace FiguresArea_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Plowad_Kruqa_Radius_4_Otvet_3_1()
        {
            //arrange
            Circle circle = new("kruq", 1);
            double expected = 3.1;

            //act
            double result = circle.GetArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Plowad_Treuqolnika_Storoni_3_4_5_Otvet_6()
        {
            //arrange
            Triangle triangle = new("treuqolnik", 3, 4, 5);
            int expected = 6;

            //act
            double result = triangle.GetArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Pramouqolniy_Treuqolnik_Storoni_3_4_5_Otvet_True()
        {
            //arrange
            Triangle triangle = new("treuqolnik", 3, 4, 5);
            bool expected = true;

            //act
            bool result = triangle.IsPramouqolniy();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}