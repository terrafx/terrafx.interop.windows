// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using static TerraFX.Interop.D3D12_ROOT_SIGNATURE_DESC;
using static TerraFX.Interop.D3D12_ROOT_SIGNATURE_FLAGS;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_ROOT_SIGNATURE_DESC" /> struct.</summary>
    public static unsafe partial class D3D12_ROOT_SIGNATURE_DESCTests
    {
        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.NumParameters, Is.EqualTo(0));
            Assert.That((nuint)DEFAULT.pParameters, Is.EqualTo((nuint)0));
            Assert.That(DEFAULT.NumStaticSamplers, Is.EqualTo(0));
            Assert.That((nuint)DEFAULT.pStaticSamplers, Is.EqualTo((nuint)0));
            Assert.That(DEFAULT.Flags, Is.EqualTo(D3D12_ROOT_SIGNATURE_FLAG_NONE));
        }
    }
}
