using NUnit.Framework;

namespace Checkout.Tests
{
    public class ExampleTests
    {

        [Test]
        public void Test0()
        {
            // Arrange
            Till till = new Till();

            // Act
            // Scan nothing

            // 
            NUnit.Framework.Assert.AreEqual(0, till.Total());
        }


        [Test]
        public void Given_A_TotalPrice_ShouldBe_50()
        {
            // Arrange
            var till = new Till();

            // Act
            till.Scan("A");

            // NUnit.Framework.Assert
            NUnit.Framework.Assert.AreEqual(50.0, till.Total());
        }
        [Test]
        public void Given_B_TotalPrice_ShouldBe_30()
        {
            // Arrange
            var till = new Till();

            // Act
            till.Scan("B");

            // NUnit.Framework.Assert
            NUnit.Framework.Assert.AreEqual(30.0, till.Total());
        }
        [Test]
        public void Given_C_TotalPrice_ShouldBe_20()
        {
            // Arrange
            var till = new Till();

            // Act
            till.Scan("C");

            // NUnit.Framework.Assert
            NUnit.Framework.Assert.AreEqual(20.0, till.Total());
        }

        [Test]
        public void Given_AB_TotalPrice_ShouldBe_80()
        {
            // Arrange
            var till = new Till();

            // Act
            till.Scan("AB");

            // Assert
            Assert.AreEqual(80.0, till.Total());
        }
        [Test]
        public void Given_BC_TotalPrice_ShouldBe_50()
        {
            // Arrange
            var till = new Till();

            // Act
            till.Scan("BC");

            // Assert
            Assert.AreEqual(50.0, till.Total());
        }
        [Test]
        public void Given_CD_TotalPrice_ShouldBe_35()
        {
            // Arrange
            var till = new Till();

            // Act
            till.Scan("CD");

            // Assert
            Assert.AreEqual(35.0, till.Total());
        }

        [Test]
        public void Given_CDBA_TotalPrice_ShouldBe_115()
        {
            Till till = new Till();
            till.Scan("CDBA");
            NUnit.Framework.Assert.AreEqual(115.0, till.Total());
        }

        [Test]
        public void Given_TwoItemsOfTypeA_TotalPrice_ShouldBe_100()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("AA");

            Assert.AreEqual(100.0, till.Total());
        }

        [Test]
        public void Given_TwoItemsOfTypeB_TotalPrice_ShouldBe_45()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("BB");

            // Assert
            Assert.AreEqual(45.0, till.Total());
        }
        [Test]
        public void Given_TwoItemsOfTypeC_TotalPrice_ShouldBe_40()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("CC");

            Assert.AreEqual(40.0, till.Total());
        }
        [Test]
        public void Given_TwoItemsOfTypeD_TotalPrice_ShouldBe_30()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("DD");

            Assert.AreEqual(30.0, till.Total());
        }

        [Test]
        public void Given_ThreeItemsOfTypeA_TotalPrice_ShouldBe_130()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("AAA");

            // Assert
            Assert.AreEqual(130.0, till.Total());
        }
        [Test]
        public void Given_AAAAAA_TotalPrice_ShouldBe_260()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("AAAAAA");

            // Assert
            Assert.AreEqual(260.0, till.Total());
        }
        [Test]
        public void Given_AAAAAAA_TotalPrice_ShouldBe_310()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("AAAAAAA");

            // Assert
            Assert.AreEqual(310.0, till.Total());
        }
        [Test]
        public void Given_BBBB_TotalPrice_ShouldBe_90()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("BBBB");

            // Assert
            Assert.AreEqual(90.0, till.Total());
        }
        [Test]
        public void Given_BBBBB_TotalPrice_ShouldBe_120()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("BBBBB");

            // Assert
            Assert.AreEqual(120.0, till.Total());
        }

        [Test]
        public void Given_TwoAAItems_TotalPrice_ShouldBe_100()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("Aa");

            // Assert
            Assert.AreEqual(100.0, till.Total());
        }
        [Test]
        public void Given_AbBAItems_TotalPrice_ShouldBe_130()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("AbBA");

            // Assert
            Assert.AreEqual(145.0, till.Total());
        }
        [Test]
        public void Given_AbaBAItems_TotalPrice_ShouldBe_175()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("AbaBA");

            // Assert
            Assert.AreEqual(175.0, till.Total());
        }
        [Test]
        public void Given_CCCCCCC_TotalPrice_ShouldBe_260()
        {
            // Arrange
            Till till = new Till();

            // Act
            till.Scan("CCCCCCCC");

            // Assert
            Assert.AreEqual(120.0, till.Total());
        }

    }
}