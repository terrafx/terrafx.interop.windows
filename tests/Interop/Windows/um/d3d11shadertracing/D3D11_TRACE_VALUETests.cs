// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_TRACE_VALUE" /> struct.</summary>
    public static unsafe partial class D3D11_TRACE_VALUETests
    {
        /// <summary>Validates that the <see cref="D3D11_TRACE_VALUE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_TRACE_VALUE>(), Is.EqualTo(sizeof(D3D11_TRACE_VALUE)));
        }

        /// <summary>Validates that the <see cref="D3D11_TRACE_VALUE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_TRACE_VALUE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_TRACE_VALUE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_TRACE_VALUE), Is.EqualTo(20));
        }
    }
}
