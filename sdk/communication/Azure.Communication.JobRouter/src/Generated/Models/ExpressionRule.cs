// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> A rule providing inline expression rules. </summary>
    public partial class ExpressionRule : RouterRule
    {
        /// <summary> Initializes a new instance of ExpressionRule. </summary>
        /// <param name="expression"> The string containing the expression to evaluate. Should contain return statement with calculated values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expression"/> is null. </exception>
        public ExpressionRule(string expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            Language = "powerFx";
            Expression = expression;
            Kind = "expression-rule";
        }

        /// <summary> Initializes a new instance of ExpressionRule. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of Rule. </param>
        /// <param name="language"> The expression language to compile to and execute. </param>
        /// <param name="expression"> The string containing the expression to evaluate. Should contain return statement with calculated values. </param>
        internal ExpressionRule(string kind, string language, string expression) : base(kind)
        {
            Language = language;
            Expression = expression;
            Kind = kind ?? "expression-rule";
        }
        /// <summary> The string containing the expression to evaluate. Should contain return statement with calculated values. </summary>
        public string Expression { get; set; }
    }
}
