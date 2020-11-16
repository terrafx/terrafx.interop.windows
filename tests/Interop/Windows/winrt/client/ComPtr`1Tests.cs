// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ComPtr{T}"/> struct.</summary>
    public static unsafe class ComPtrTests
    {
        /// <summary>Validates that the <see cref="ComPtr{T}.RIID" /> value is correct.</summary>
        [Test]
        public static void RIIDTest()
        {
            Assert.IsTrue(ComPtr<IInspectable>.RIID != null);

            Guid guid = *ComPtr<IInspectable>.RIID;

            Assert.That(guid, Is.EqualTo(IID_IInspectable));
        }
    }
}
