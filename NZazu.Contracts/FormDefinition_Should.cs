﻿using FluentAssertions;
using NUnit.Framework;

namespace NZazu.Contracts
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    internal class FormDefinition_Should
    {
        [Test]
        public void Be_Creatable()
        {
            var sut = new FormDefinition();

            sut.Should().NotBeNull();
            sut.Fields.Should().BeNull();
        }
    }
}