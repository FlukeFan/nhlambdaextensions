
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

using NHibernate.Criterion;

namespace NHibernate.LambdaExtensions
{

    /// <summary>
    /// Provides typesafe sub-queries using lambda expressions to express properties
    /// </summary>
    public class SafeSubquery
    {

        /// <summary>
        /// Protected constructor - class not for instantiation
        /// </summary>
        protected SafeSubquery() { }

        /// <summary>
        /// Create a ICriterion for the specified property subquery expression
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>returns SafeSubqueryBuilder</returns>
        public static SafeSubqueryBuilder Property<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return new SafeSubqueryBuilder(property);
        }

    }

}

