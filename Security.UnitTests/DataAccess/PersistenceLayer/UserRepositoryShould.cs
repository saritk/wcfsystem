using System.Collections.Generic;
using FluentNHibernate.Testing.Values;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Language.Flow;
using NHibernate;
using NHibernate.Mapping;
using PersistenceLayer;
using PersistenceLayer.Entities;

namespace Security.UnitTests.DataAccess.PersistenceLayer
{
    [TestClass]
    public class UserRepositoryShould
    {
        private Mock<INHibernateHelper> _nHibernateHelperMock;
        private Mock<ISession> _sessionMock;

        [TestInitialize]
        public void Init()
        {
            _nHibernateHelperMock = new Mock<INHibernateHelper>();
            _sessionMock = new Mock<ISession>();

            _nHibernateHelperMock.Setup(o => o.OpenSession()).Returns(_sessionMock.Object);

        }

        [TestMethod]
        public void ReturnUserById()
        {
            //Arrange
            const int userId = 1;
            var expectedUser = new UserDo {Id = userId, Password = "123", UserName = "sara"};
           // _sessionMock.Setup(o => o.QueryOver<UserDo>()).Returns((expectedUser));
        
            //Act
            var target = new UserRepository(_nHibernateHelperMock.Object);
            var actualUser = target.GetUser(userId);

            //Assert
            Assert.AreEqual(expectedUser.Id, actualUser.Id);
            Assert.AreEqual(expectedUser.Password, actualUser.Password);
            Assert.AreEqual(expectedUser.UserName, actualUser.UserName);

        }



    }
}
