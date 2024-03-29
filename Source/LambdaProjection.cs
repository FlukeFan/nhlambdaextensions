
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
    /// Provides typesafe projections using lambda expressions to express properties
    /// </summary>
    public class LambdaProjection
    {

        /// <summary>
        /// Protected constructor - class not for instantiation
        /// </summary>
        protected LambdaProjection() { }

        /// <summary>
        /// Create an IProjection for the specified property expression
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.PropertyProjection</returns>
        public static PropertyProjection Property<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Property(property);
        }

        /// <summary>
        /// Create an IProjection for the specified property expression
        /// </summary>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.PropertyProjection</returns>
        public static PropertyProjection Property(Expression<Func<object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Property(property);
        }

        /// <summary>
        /// Assign an alias to a projection by wrapping it
        /// </summary>
        /// <param name="projection">the projection to wrap</param>
        /// <param name="alias">LambdaExpression returning an alias</param>
        /// <returns>return NHibernate.Criterion.IProjection</returns>
        public static IProjection Alias(IProjection                 projection,
                                        Expression<Func<object>>    alias)
        {
            string aliasContainer = ExpressionProcessor.FindMemberExpression(alias.Body);
            return Projections.Alias(projection, aliasContainer);
        }

        /// <summary>
        /// Average projection
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.AggregateProjection</returns>
        public static AggregateProjection Avg<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Avg(property);
        }

        /// <summary>
        /// Average projection
        /// </summary>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.AggregateProjection</returns>
        public static AggregateProjection Avg(Expression<Func<object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Avg(property);
        }

        /// <summary>
        /// Count projection
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.CountProjection</returns>
        public static CountProjection Count<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Count(property);
        }

        /// <summary>
        /// Count projection
        /// </summary>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.CountProjection</returns>
        public static CountProjection Count(Expression<Func<object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Count(property);
        }

        /// <summary>
        /// CountDistinct projection
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.CountProjection</returns>
        public static CountProjection CountDistinct<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.CountDistinct(property);
        }

        /// <summary>
        /// CountDistinct projection
        /// </summary>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.CountProjection</returns>
        public static CountProjection CountDistinct(Expression<Func<object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.CountDistinct(property);
        }

        /// <summary>
        /// Group property projection
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.PropertyProjection</returns>
        public static PropertyProjection GroupProperty<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.GroupProperty(property);
        }

        /// <summary>
        /// Group property projection
        /// </summary>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.PropertyProjection</returns>
        public static PropertyProjection GroupProperty(Expression<Func<object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.GroupProperty(property);
        }

        /// <summary>
        /// Max projection
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.AggregateProjection</returns>
        public static AggregateProjection Max<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Max(property);
        }

        /// <summary>
        /// Max projection
        /// </summary>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.AggregateProjection</returns>
        public static AggregateProjection Max(Expression<Func<object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Max(property);
        }

        /// <summary>
        /// Min projection
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.AggregateProjection</returns>
        public static AggregateProjection Min<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Min(property);
        }

        /// <summary>
        /// Min projection
        /// </summary>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.AggregateProjection</returns>
        public static AggregateProjection Min(Expression<Func<object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Min(property);
        }

        /// <summary>
        /// Sum projection
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.AggregateProjection</returns>
        public static AggregateProjection Sum<T>(Expression<Func<T, object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Sum(property);
        }

        /// <summary>
        /// Sum projection
        /// </summary>
        /// <param name="expression">lambda expression</param>
        /// <returns>return NHibernate.Criterion.AggregateProjection</returns>
        public static AggregateProjection Sum(Expression<Func<object>> expression)
        {
            string property = ExpressionProcessor.FindMemberExpression(expression.Body);
            return Projections.Sum(property);
        }

    }

}

