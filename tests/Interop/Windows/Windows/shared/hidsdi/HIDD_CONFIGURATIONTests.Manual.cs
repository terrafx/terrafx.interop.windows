// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidsdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="HIDD_CONFIGURATION" /> struct.</summary>
    public static unsafe partial class HIDD_CONFIGURATIONTests
    {
        /// <summary>Validates that the <see cref="HIDD_CONFIGURATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HIDD_CONFIGURATION>(), Is.EqualTo(sizeof(HIDD_CONFIGURATION)));
        }

        /// <summary>Validates that the <see cref="HIDD_CONFIGURATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HIDD_CONFIGURATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HIDD_CONFIGURATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HIDD_CONFIGURATION), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(HIDD_CONFIGURATION), Is.EqualTo(12));
            }
        }
    }
}
