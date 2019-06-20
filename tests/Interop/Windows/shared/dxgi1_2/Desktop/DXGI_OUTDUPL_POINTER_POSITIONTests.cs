// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.Desktop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_OUTDUPL_POINTER_POSITION" /> struct.</summary>
    public static class DXGI_OUTDUPL_POINTER_POSITIONTests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_OUTDUPL_POINTER_POSITION" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_OUTDUPL_POINTER_POSITION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_OUTDUPL_POINTER_POSITION" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_OUTDUPL_POINTER_POSITION>(), Is.EqualTo(12));
        }
    }
}
