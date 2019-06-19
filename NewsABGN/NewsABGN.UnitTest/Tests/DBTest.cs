using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsABGN.DB;

namespace NewsABGN.UnitTest.Tests
{
    [TestClass]
    public class DBTest
    {
        [TestMethod]
        public void Member_Insert_Test()
        {
            int originalDataCount = DataRepository.Member.GetCount(x => true);

            Member member = new Member();
            member.Id = "newTestMemberId";
            member.Password = "newTestMemberPassword";
            member.Name = "FreakinYOLOSwag";
            member.Age = 3;
            member.Email = "gugu@a.a";
            member.Phone = "230948";
            member.City = "감자국";
            DataRepository.Member.Insert(member);

            int newDataCount = DataRepository.Member.GetCount(x => true);

            var memberList = DataRepository.Member.GetAll();
            var lastInsertedMember = memberList[memberList.Count - 1];

            Assert.AreEqual(originalDataCount + 1, newDataCount);
            Assert.AreEqual(member.Id, lastInsertedMember.Id);
            Assert.AreEqual(member.Password, lastInsertedMember.Password);
            Assert.AreEqual(member.Name, lastInsertedMember.Name);
            Assert.AreEqual(member.Age, lastInsertedMember.Age);
            Assert.AreEqual(member.Email, lastInsertedMember.Email);
            Assert.AreEqual(member.Phone, lastInsertedMember.Phone);
            Assert.AreEqual(member.City, lastInsertedMember.City);
        }

        [TestMethod]
        public void Member_Update_Test()
        {
            Member member = DataRepository.Member.GetLastMember();
            if (member == null)
                return;
            string newName = "updatedMF";

            member.Name = newName;
            DataRepository.Member.Update(member);

            member = DataRepository.Member.GetLastMember();

            Assert.AreEqual(member.Name, newName);

        }

        [TestMethod]
        public void Member_Delete_Test()
        {
            Member member = DataRepository.Member.GetLastMember();
            if (member == null)
                return;

            int originalMemberCount = DataRepository.Member.GetAll().Count;
            DataRepository.Member.Delete(member);
            int newMemberCount = DataRepository.Member.GetAll().Count;

            Assert.AreEqual(originalMemberCount - 1, newMemberCount);


        }




    }
}
