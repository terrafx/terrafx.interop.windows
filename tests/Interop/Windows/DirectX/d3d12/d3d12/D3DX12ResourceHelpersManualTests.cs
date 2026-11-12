// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;
using static TerraFX.Interop.DirectX.D3D12;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_TEXTURE_LAYOUT;
using static TerraFX.Interop.DirectX.DXGI_FORMAT;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported D3DX12 resource helpers.</summary>
public static unsafe class D3DX12ResourceHelpersManualTests
{
    /// <summary>Valid tight alignments are retained when the runtime supports tight alignment.</summary>
    [Test]
    public static void D3DX12ConditionallyExpandAPIDesc_PreservesValidTightAlignmentFloor()
    {
        D3D12_RESOURCE_DESC1 desc = new(D3D12_RESOURCE_DIMENSION_BUFFER, 128, 4096, 1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, D3D12_RESOURCE_FLAG_USE_TIGHT_ALIGNMENT);
        D3D12_RESOURCE_DESC1 expanded = default;

        ref readonly D3D12_RESOURCE_DESC1 result = ref DirectX.D3DX12ConditionallyExpandAPIDesc(ref expanded, in desc, tightAlignmentSupported: true);

        Assert.That(result.Alignment, Is.EqualTo(128UL));
    }

    /// <summary>Invalid tight alignments are replaced by the specification minimum.</summary>
    [Test]
    public static void D3DX12ConditionallyExpandAPIDesc_ClampsInvalidTightAlignment()
    {
        D3D12_RESOURCE_DESC2 desc = D3D12_RESOURCE_DESC2.Buffer(4096, D3D12_RESOURCE_FLAG_USE_TIGHT_ALIGNMENT, 96);
        D3D12_RESOURCE_DESC2 expanded = default;

        ref readonly D3D12_RESOURCE_DESC2 result = ref DirectX.D3DX12ConditionallyExpandAPIDesc(ref expanded, in desc, tightAlignmentSupported: true);

        Assert.That(result.Alignment, Is.EqualTo((ulong)D3D12_TIGHT_ALIGNMENT_MIN_PLACED_RESOURCE_ALIGNMENT));
    }

    /// <summary>Copyable footprints preserve row layout and reject a subresource index at the end boundary.</summary>
    [Test]
    public static void D3DX12GetCopyableFootprints_UsesDesc2AndRejectsEndBoundary()
    {
        D3D12_RESOURCE_DESC2 desc = D3D12_RESOURCE_DESC2.Tex2D(DXGI_FORMAT_R8G8B8A8_UNORM, 1, 1, mipLevels: 1);
        D3D12_PLACED_SUBRESOURCE_FOOTPRINT layout = default;
        uint rows = 0;
        ulong rowSize = 0;
        ulong totalBytes = 0;

        Assert.That(DirectX.D3DX12GetCopyableFootprints(in desc, 0, 1, 128, &layout, &rows, &rowSize, &totalBytes), Is.True);
        Assert.That(layout.Offset, Is.EqualTo(128UL));
        Assert.That(layout.Footprint.RowPitch, Is.EqualTo(256U));
        Assert.That(rows, Is.EqualTo(1U));
        Assert.That(rowSize, Is.EqualTo(4UL));
        Assert.That(totalBytes, Is.EqualTo(4UL));

        Assert.That(DirectX.D3DX12GetCopyableFootprints(in desc, 1, 1, 0, &layout, &rows, &rowSize, &totalBytes), Is.True);
        Assert.That(totalBytes, Is.Zero);
        Assert.That(layout.Offset, Is.EqualTo(ulong.MaxValue));
        Assert.That(rows, Is.EqualTo(uint.MaxValue));
        Assert.That(rowSize, Is.EqualTo(ulong.MaxValue));
    }
}
