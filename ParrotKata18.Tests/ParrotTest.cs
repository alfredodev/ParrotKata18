using Xunit;

namespace ParrotKata18.Tests
{
    public class ParrotTest
    {
        [Fact]
        public void GetSpeedOfEuropeanParrot()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.EUROPEAN, 0, 0, false);
            Assert.Equal(12.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_One_Coconut()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.AFRICAN, 1, 0, false);
            Assert.Equal(3.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.AFRICAN, 2, 0, false);
            Assert.Equal(0.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_No_Coconuts()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.AFRICAN, 0, 0, false);
            Assert.Equal(12.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_nailed()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 0, true);
            Assert.Equal(0.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 1.5, false);
            Assert.Equal(18.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
        {
            Parrot parrot = new Parrot(ParrotTypeEnum.NORWEGIAN_BLUE, 0, 4, false);
            Assert.Equal(24.0, parrot.GetSpeed());
        }
    }
}
