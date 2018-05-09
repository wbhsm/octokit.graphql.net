﻿using System;
using System.Linq.Expressions;

namespace Octokit.GraphQL.Core.Builders
{
    class SubqueryExpression : Expression
    {
        public SubqueryExpression(ISubquery subquery, MethodCallExpression methodCall)
        {
            Subquery = subquery;
            MethodCall = methodCall;
        }

        public MethodCallExpression MethodCall { get; }
        public override ExpressionType NodeType => ExpressionType.Extension;
        public ISubquery Subquery { get; }
        public override Type Type => MethodCall.Type;
    }
}
