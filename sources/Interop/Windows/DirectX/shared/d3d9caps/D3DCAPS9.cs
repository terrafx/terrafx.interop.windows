// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9"]/*' />
public partial struct D3DCAPS9
{
    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.DeviceType"]/*' />
    public D3DDEVTYPE DeviceType;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.AdapterOrdinal"]/*' />
    public uint AdapterOrdinal;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.Caps"]/*' />
    [NativeTypeName("DWORD")]
    public uint Caps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.Caps2"]/*' />
    [NativeTypeName("DWORD")]
    public uint Caps2;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.Caps3"]/*' />
    [NativeTypeName("DWORD")]
    public uint Caps3;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.PresentationIntervals"]/*' />
    [NativeTypeName("DWORD")]
    public uint PresentationIntervals;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.CursorCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint CursorCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.DevCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint DevCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.PrimitiveMiscCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint PrimitiveMiscCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.RasterCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint RasterCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.ZCmpCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint ZCmpCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.SrcBlendCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint SrcBlendCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.DestBlendCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint DestBlendCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.AlphaCmpCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint AlphaCmpCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.ShadeCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint ShadeCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.TextureCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint TextureCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.TextureFilterCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint TextureFilterCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.CubeTextureFilterCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint CubeTextureFilterCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.VolumeTextureFilterCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint VolumeTextureFilterCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.TextureAddressCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint TextureAddressCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.VolumeTextureAddressCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint VolumeTextureAddressCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.LineCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint LineCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxTextureWidth"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTextureWidth;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxTextureHeight"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTextureHeight;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxVolumeExtent"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxVolumeExtent;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxTextureRepeat"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTextureRepeat;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxTextureAspectRatio"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTextureAspectRatio;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxAnisotropy"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxAnisotropy;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxVertexW"]/*' />
    public float MaxVertexW;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.GuardBandLeft"]/*' />
    public float GuardBandLeft;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.GuardBandTop"]/*' />
    public float GuardBandTop;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.GuardBandRight"]/*' />
    public float GuardBandRight;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.GuardBandBottom"]/*' />
    public float GuardBandBottom;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.ExtentsAdjust"]/*' />
    public float ExtentsAdjust;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.StencilCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint StencilCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.FVFCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint FVFCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.TextureOpCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint TextureOpCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxTextureBlendStages"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTextureBlendStages;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxSimultaneousTextures"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxSimultaneousTextures;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.VertexProcessingCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint VertexProcessingCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxActiveLights"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxActiveLights;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxUserClipPlanes"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxUserClipPlanes;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxVertexBlendMatrices"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxVertexBlendMatrices;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxVertexBlendMatrixIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxVertexBlendMatrixIndex;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxPointSize"]/*' />
    public float MaxPointSize;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxPrimitiveCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxPrimitiveCount;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxVertexIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxVertexIndex;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxStreams"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxStreams;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxStreamStride"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxStreamStride;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.VertexShaderVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint VertexShaderVersion;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxVertexShaderConst"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxVertexShaderConst;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.PixelShaderVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint PixelShaderVersion;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.PixelShader1xMaxValue"]/*' />
    public float PixelShader1xMaxValue;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.DevCaps2"]/*' />
    [NativeTypeName("DWORD")]
    public uint DevCaps2;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxNpatchTessellationLevel"]/*' />
    public float MaxNpatchTessellationLevel;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.Reserved5"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved5;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MasterAdapterOrdinal"]/*' />
    public uint MasterAdapterOrdinal;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.AdapterOrdinalInGroup"]/*' />
    public uint AdapterOrdinalInGroup;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.NumberOfAdaptersInGroup"]/*' />
    public uint NumberOfAdaptersInGroup;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.DeclTypes"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeclTypes;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.NumSimultaneousRTs"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumSimultaneousRTs;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.StretchRectFilterCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint StretchRectFilterCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.VS20Caps"]/*' />
    public D3DVSHADERCAPS2_0 VS20Caps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.PS20Caps"]/*' />
    public D3DPSHADERCAPS2_0 PS20Caps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.VertexTextureFilterCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint VertexTextureFilterCaps;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxVShaderInstructionsExecuted"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxVShaderInstructionsExecuted;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxPShaderInstructionsExecuted"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxPShaderInstructionsExecuted;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxVertexShader30InstructionSlots"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxVertexShader30InstructionSlots;

    /// <include file='D3DCAPS9.xml' path='doc/member[@name="D3DCAPS9.MaxPixelShader30InstructionSlots"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxPixelShader30InstructionSlots;
}
