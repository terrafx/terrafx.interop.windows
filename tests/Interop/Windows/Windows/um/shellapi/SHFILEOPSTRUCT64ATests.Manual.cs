// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="SHFILEOPSTRUCT64A" /> struct.</summary>
    public static unsafe partial class SHFILEOPSTRUCT64ATests
    {
        /// <summary>Validates that the <see cref="SHFILEOPSTRUCT64A" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SHFILEOPSTRUCT64A>(), Is.EqualTo(sizeof(SHFILEOPSTRUCT64A)));
        }

        /// <summary>Validates that the <see cref="SHFILEOPSTRUCT64A" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SHFILEOPSTRUCT64A).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SHFILEOPSTRUCT64A" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SHFILEOPSTRUCT64A), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(SHFILEOPSTRUCT64A), Is.EqualTo(32));
            }
        }
    }
}
