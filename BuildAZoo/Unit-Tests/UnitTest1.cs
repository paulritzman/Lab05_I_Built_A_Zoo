using BuildAZoo.Classes;
using BuildAZoo.Interfaces;
using System;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void BlackWidowIsAssignableFromAnimal_ProvingBlackWidowIsAnAnimal()
        {
            BlackWidow blackWidow = new BlackWidow();

            Assert.IsAssignableFrom<Animal>(blackWidow);
        }

        [Fact]
        public void VampireBatIsAssignableFromAnimal_ProvingVampireBatImplementsICanFly()
        {
            VampireBat vampBat = new VampireBat();

            Assert.IsAssignableFrom<ICanFly>(vampBat);
        }

        [Fact]
        public void BatmanCanReturnTrueForHasEarBones_ProvingBatmanInheretsFromMammal()
        {
            Batman bruceWayne = new Batman();

            Assert.True(bruceWayne.HasEarBones);
        }

        [Fact]
        public void BatmanAndVampireBatCanReturnDifferentStringsForHowIFlyMethod_ProvingMethodOverride()
        {
            Batman bruceWayne = new Batman();
            VampireBat vampBat = new VampireBat();


            Assert.NotEqual(bruceWayne.HowIFly(), vampBat.HowIFly());
        }
    }
}
