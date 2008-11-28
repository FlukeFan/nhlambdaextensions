
using System;

using NHibernate;
using NHibernate.Criterion;

using NUnit.Framework;

namespace NHibernate.LambdaExtensions.Test
{

    [TestFixture]
    public class TestLExtension : TestBase
    {

        private void AssertCriteriaAreEqual(DetachedCriteria expected, DetachedCriteria actual)
        {
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void Test_Between()
        {
            DetachedCriteria expected =
                DetachedCriteria.For<Person>()
                    .Add(Restrictions.Between("Age", 5, 10));

            DetachedCriteria actual =
                DetachedCriteria.For<Person>()
                    .Add(Restrictions<Person>.Between(p => p.Age, 5, 10));

            AssertCriteriaAreEqual(expected, actual);
        }

        [Test]
        public void Test_Like()
        {
            DetachedCriteria expected =
                DetachedCriteria.For<Person>()
                    .Add(Restrictions.Like("Name", "%test%"));

            DetachedCriteria actual =
                DetachedCriteria.For<Person>()
                    .Add(Restrictions<Person>.Like(p => p.Name, "%test%"));

            AssertCriteriaAreEqual(expected, actual);
        }

    }

}
