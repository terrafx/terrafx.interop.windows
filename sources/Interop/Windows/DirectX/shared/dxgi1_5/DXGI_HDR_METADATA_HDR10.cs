// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10"]/*' />
public partial struct DXGI_HDR_METADATA_HDR10
{
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.RedPrimary"]/*' />
    [NativeTypeName("UINT16[2]")]
    public _RedPrimary_e__FixedBuffer RedPrimary;

    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.GreenPrimary"]/*' />
    [NativeTypeName("UINT16[2]")]
    public _GreenPrimary_e__FixedBuffer GreenPrimary;

    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.BluePrimary"]/*' />
    [NativeTypeName("UINT16[2]")]
    public _BluePrimary_e__FixedBuffer BluePrimary;

    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.WhitePoint"]/*' />
    [NativeTypeName("UINT16[2]")]
    public _WhitePoint_e__FixedBuffer WhitePoint;

    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.MaxMasteringLuminance"]/*' />
    public uint MaxMasteringLuminance;

    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.MinMasteringLuminance"]/*' />
    public uint MinMasteringLuminance;

    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.MaxContentLightLevel"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MaxContentLightLevel;

    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.MaxFrameAverageLightLevel"]/*' />
    [NativeTypeName("UINT16")]
    public ushort MaxFrameAverageLightLevel;

    /// <include file='_RedPrimary_e__FixedBuffer.xml' path='doc/member[@name="_RedPrimary_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _RedPrimary_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_GreenPrimary_e__FixedBuffer.xml' path='doc/member[@name="_GreenPrimary_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _GreenPrimary_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_BluePrimary_e__FixedBuffer.xml' path='doc/member[@name="_BluePrimary_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _BluePrimary_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_WhitePoint_e__FixedBuffer.xml' path='doc/member[@name="_WhitePoint_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _WhitePoint_e__FixedBuffer
    {
        public ushort e0;
    }
}
