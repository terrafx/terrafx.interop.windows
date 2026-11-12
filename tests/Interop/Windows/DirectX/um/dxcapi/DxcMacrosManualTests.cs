// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates the DXC FourCC helper.</summary>
public static class DxcMacrosManualTests
{
    /// <summary>Four-character codes pack bytes in little-endian order.</summary>
    [Test]
    public static void FourCCUsesLittleEndianPacking()
    {
        Assert.That(DXC.DXC_FOURCC('D', 'X', 'I', 'L'), Is.EqualTo(DXC.DXC_PART_DXIL));
        Assert.That(DXC.DXC_FOURCC('I', 'L', 'D', 'B'), Is.EqualTo(DXC.DXC_PART_PDB));
    }
}
