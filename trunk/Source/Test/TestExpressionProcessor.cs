
using System;
using System.Linq.Expressions;

using NHibernate.Criterion;

using NUnit.Framework;

namespace NHibernate.LambdaExtensions.Test
{

    [TestFixture]
    public class TestExpressionProcessor : TestBase
    {

        [Test]
        public void TestFindMemberExpressionReference()
        {
            Expression<Func<Person, string>> e = (Person p) => p.Name;
            string property = ExpressionProcessor.FindMemberExpression(e.Body);
            Assert.AreEqual("Name", property);
        }

        [Test]
        public void TestFindMemberExpressionValue()
        {
            Expression<Func<Person, object>> e = (Person p) => p.Age;
            string property = ExpressionProcessor.FindMemberExpression(e.Body);
            Assert.AreEqual("Age", property);
        }

        [Test]
        public void TestEvaluatePropertyExpression()
        {
            string testName = "testName";
            ICriterion criterion = ExpressionProcessor.ProcessExpression<Person>(p => p.Name == testName);
            SimpleExpression simpleExpression = (SimpleExpression)criterion;
            Assert.AreEqual("testName", simpleExpression.Value);
        }

        [Test]
        public void TestEvaluateEnumeration()
        {
            ICriterion before = Restrictions.Eq("Gender", PersonGender.Female);
            ICriterion after = ExpressionProcessor.ProcessExpression<Person>(p => p.Gender == PersonGender.Female);
            Assert.AreEqual(before.ToString(), after.ToString());
        }

        [Test]
        public void TestEvaluateMemberExpression()
        {
            Person testPerson = new Person();
            testPerson.Name = "testName";
            ICriterion criterion = ExpressionProcessor.ProcessExpression<Person>(p => p.Name == testPerson.Name);
            SimpleExpression simpleExpression = (SimpleExpression)criterion;
            Assert.AreEqual("testName", simpleExpression.Value);
        }

    }

}
