using System;
using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;

namespace NetFabric.Expressions
{
    public static partial class ExpressionEx
    {
        public static Expression Is(Expression expression, Type type)
            => NotEqual(TypeAs(expression, type), Constant(null));

        public static Expression Is(Expression expression, Type type, ParameterExpression result)
            => Block(
                Assign(result, TypeAs(expression, type)),
                NotEqual(result, Constant(null))
            );
    }
}