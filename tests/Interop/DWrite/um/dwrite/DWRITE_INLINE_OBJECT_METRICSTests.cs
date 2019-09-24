// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_INLINE_OBJECT_METRICS" /> struct.</summary>
    public static class DWRITE_INLINE_OBJECT_METRICSTests
    {
        /// <summary>Validates that the layout of the <see cref="DWRITE_INLINE_OBJECT_METRICS" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_INLINE_OBJECT_METRICS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DWRITE_INLINE_OBJECT_METRICS" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_INLINE_OBJECT_METRICS>(), Is.EqualTo(16));
        }
    }
}
