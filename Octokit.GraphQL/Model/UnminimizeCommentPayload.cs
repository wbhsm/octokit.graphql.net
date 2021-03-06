namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UnminimizeComment
    /// </summary>
    public class UnminimizeCommentPayload : QueryableValue<UnminimizeCommentPayload>
    {
        internal UnminimizeCommentPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The comment that was unminimized.
        /// </summary>
        public IMinimizable UnminimizedComment => this.CreateProperty(x => x.UnminimizedComment, Octokit.GraphQL.Model.Internal.StubIMinimizable.Create);

        internal static UnminimizeCommentPayload Create(Expression expression)
        {
            return new UnminimizeCommentPayload(expression);
        }
    }
}