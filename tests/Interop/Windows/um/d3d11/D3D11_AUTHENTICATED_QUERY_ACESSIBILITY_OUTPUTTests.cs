// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT" /> struct.</summary>
    public static unsafe class D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUTTests
    {
        /// <summary>Validates that the <see cref="D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT>(), Is.EqualTo(sizeof(D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT)));
        }

        /// <summary>Validates that the <see cref="D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT), Is.EqualTo(56));
            }
        }
    }
}
