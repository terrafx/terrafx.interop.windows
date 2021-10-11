// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITransferMediumItem" /> struct.</summary>
    public static unsafe partial class ITransferMediumItemTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITransferMediumItem" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITransferMediumItem).GUID, Is.EqualTo(IID_ITransferMediumItem));
        }

        /// <summary>Validates that the <see cref="ITransferMediumItem" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITransferMediumItem>(), Is.EqualTo(sizeof(ITransferMediumItem)));
        }

        /// <summary>Validates that the <see cref="ITransferMediumItem" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITransferMediumItem).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITransferMediumItem" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITransferMediumItem), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITransferMediumItem), Is.EqualTo(4));
            }
        }
    }
}
