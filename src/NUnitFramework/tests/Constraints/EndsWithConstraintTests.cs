// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

using System;
using NUnit.Framework.Internal;

namespace NUnit.Framework.Constraints
{
    [TestFixture]
    public class EndsWithConstraintTests : StringConstraintTests
    {
        [SetUp]
        public void SetUp()
        {
            TheConstraint = new EndsWithConstraint("hello");
            ExpectedDescription = "String ending with \"hello\"";
            StringRepresentation = "<endswith \"hello\">";
        }

        static object[] SuccessData = new object[] { "hello", "I said hello" };

        static object[] FailureData = new object[] {
            new TestCaseData( "goodbye", "\"goodbye\"" ), 
            new TestCaseData( "hello there", "\"hello there\"" ),
            new TestCaseData( "say hello to Fred", "\"say hello to Fred\"" ),
            new TestCaseData( string.Empty, "<string.Empty>" ),
            new TestCaseData( null , "null" ) };
    }

    [TestFixture]
    public class EndsWithConstraintTestsIgnoringCase : StringConstraintTests
    {
        [SetUp]
        public void SetUp()
        {
            TheConstraint = new EndsWithConstraint("hello").IgnoreCase;
            ExpectedDescription = "String ending with \"hello\", ignoring case";
            StringRepresentation = "<endswith \"hello\">";
        }

        static object[] SuccessData = new object[] { "HELLO", "I said Hello" };

        static object[] FailureData = new object[] {
            new TestCaseData( "goodbye", "\"goodbye\"" ), 
            new TestCaseData( "What the hell?", "\"What the hell?\"" ),
            new TestCaseData( "hello there", "\"hello there\"" ),
            new TestCaseData( "say hello to Fred", "\"say hello to Fred\"" ),
            new TestCaseData( string.Empty, "<string.Empty>" ),
            new TestCaseData( null , "null" ) };
    }
}
