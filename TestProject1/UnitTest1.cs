using NUnit.Framework;
using SCM_Problem_2;
using SCM_Problem_2.Serviec;


namespace TestProject1
{
    public class Tests
    {

       


        [Test]
        public void ShouldReturnVideoSlipOnly()
        {
            var result = OrderProcess.ConvertToType(new string[] { "video", "Random" });
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual(1, result.Operations.Count);

        }

        [Test]
        public void ShouldReturnVideoLearningToSkiSlipOnly()
        {
            var result = OrderProcess.ConvertToType(new string[] { "video", "Learning To Ski" });
            Assert.AreEqual("Learning To Ski", result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual("First Aid video added to the packing slip", result.Operations[1]);
            Assert.AreEqual(2, result.Operations.Count);
        }

        [Test]
        public void ShouldReturnUpgradeSlipOnly()
        {
            var result = OrderProcess.ConvertToType(new string[] { "Upgrade", "Random" });
            Assert.IsNull(result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual("Apply the upgrade", result.Operations[1]);
            Assert.AreEqual("Mail Sent", result.Operations[2]);
            Assert.AreEqual(3, result.Operations.Count);

        }

        [Test]
        public void ShouldReturnMembershipSlip()
        {
            var result = OrderProcess.ConvertToType(new string[] { "Membership", "Random" });
            Assert.IsNull(result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual("Active The MemberShip", result.Operations[1]);
            Assert.AreEqual("Mail Sent", result.Operations[2]);
            Assert.AreEqual(3, result.Operations.Count);

        }

        [Test]
        public void ShouldReturnBookSlipOnly()
        {
            var result = OrderProcess.ConvertToType(new string[] { "Book", "Random" });
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip for shipping.", result.Operations[0]);
            Assert.AreEqual("Commission payment to the agent", result.Operations[1]);
            Assert.AreEqual("Create a duplicate packing slip for the royalty department.", result.Operations[2]);
            Assert.AreEqual(3, result.Operations.Count);

        }

        [Test]
        public void ShouldReturnOther()
        {
            var result = OrderProcess.ConvertToType(new string[] { "other", "Random" });
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip for shipping.", result.Operations[0]);
            Assert.AreEqual("Commission payment to the agent", result.Operations[1]);
            Assert.AreEqual(2, result.Operations.Count);

            result = OrderProcess.ConvertToType(new string[] { "random", "Random" });
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip for shipping.", result.Operations[0]);
            Assert.AreEqual("Commission payment to the agent", result.Operations[1]);
            Assert.AreEqual(2, result.Operations.Count);
        }
    }
}