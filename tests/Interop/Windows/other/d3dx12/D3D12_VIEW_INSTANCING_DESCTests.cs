// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using static TerraFX.Interop.D3D12_VIEW_INSTANCING_DESC;
using static TerraFX.Interop.D3D12_VIEW_INSTANCING_FLAGS;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_VIEW_INSTANCING_DESC" /> struct.</summary>
    public static unsafe partial class D3D12_VIEW_INSTANCING_DESCTests
    {
        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.ViewInstanceCount, Is.EqualTo(0));
            Assert.That((nuint)DEFAULT.pViewInstanceLocations, Is.EqualTo((nuint)0));
            Assert.That(DEFAULT.Flags, Is.EqualTo(D3D12_VIEW_INSTANCING_FLAG_NONE));
        }
    }
}
