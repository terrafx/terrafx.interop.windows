// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D11_COMPARISON_FUNC;
using static TerraFX.Interop.D3D11_FILTER;
using static TerraFX.Interop.D3D11_SAMPLER_DESC;
using static TerraFX.Interop.D3D11_TEXTURE_ADDRESS_MODE;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_SAMPLER_DESC" /> struct.</summary>
    public static unsafe class D3D11_SAMPLER_DESCTests
    {
        /// <summary>Validates that the <see cref="D3D11_SAMPLER_DESC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_SAMPLER_DESC>(), Is.EqualTo(sizeof(D3D11_SAMPLER_DESC)));
        }

        /// <summary>Validates that the <see cref="D3D11_SAMPLER_DESC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_SAMPLER_DESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_SAMPLER_DESC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_SAMPLER_DESC), Is.EqualTo(52));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.Filter, Is.EqualTo(D3D11_FILTER_MIN_MAG_MIP_LINEAR));
            Assert.That(DEFAULT.AddressU, Is.EqualTo(D3D11_TEXTURE_ADDRESS_CLAMP));
            Assert.That(DEFAULT.AddressV, Is.EqualTo(D3D11_TEXTURE_ADDRESS_CLAMP));
            Assert.That(DEFAULT.AddressW, Is.EqualTo(D3D11_TEXTURE_ADDRESS_CLAMP));
            Assert.That(DEFAULT.MipLODBias, Is.EqualTo(0));
            Assert.That(DEFAULT.MaxAnisotropy, Is.EqualTo(1));
            Assert.That(DEFAULT.ComparisonFunc, Is.EqualTo(D3D11_COMPARISON_NEVER));
            Assert.That(DEFAULT.BorderColor[0], Is.EqualTo(1.0f));
            Assert.That(DEFAULT.BorderColor[1], Is.EqualTo(1.0f));
            Assert.That(DEFAULT.BorderColor[2], Is.EqualTo(1.0f));
            Assert.That(DEFAULT.BorderColor[3], Is.EqualTo(1.0f));
            Assert.That(DEFAULT.MinLOD, Is.EqualTo(float.MinValue));
            Assert.That(DEFAULT.MaxLOD, Is.EqualTo(float.MaxValue));
        }
    }
}
