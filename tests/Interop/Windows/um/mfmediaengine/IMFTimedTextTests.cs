// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFTimedText" /> struct.</summary>
    public static unsafe class IMFTimedTextTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFTimedText" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFTimedText).GUID, Is.EqualTo(IID_IMFTimedText));
        }

        /// <summary>Validates that the <see cref="IMFTimedText" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFTimedText>(), Is.EqualTo(sizeof(IMFTimedText)));
        }

        /// <summary>Validates that the <see cref="IMFTimedText" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFTimedText).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFTimedText" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFTimedText), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFTimedText), Is.EqualTo(4));
            }
        }
    }
}
