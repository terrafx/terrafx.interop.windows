// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="__uuidof{T}"/> API.</summary>
    public static unsafe class __uuidofTests
    {
        /// <summary>Validates the <see cref="__uuidof{T}" /> pointer conversion.</summary>
        [Test]
        public static void PointerTest()
        {
            Guid* p = __uuidof<IInspectable>();

            Assert.IsTrue(p != null);

            Guid guid = *p;

            Assert.That(guid, Is.EqualTo(IID_IInspectable));
        }

        /// <summary>Validates the <see cref="__uuidof{T}" /> <see cref="Guid"/> conversion.</summary>
        [Test]
        public static void ValueTest()
        {
            Guid guid = __uuidof<IInspectable>();

            Assert.That(guid, Is.EqualTo(IID_IInspectable));
        }
    }
}
