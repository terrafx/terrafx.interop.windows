// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WIA_DATA_TRANSFER_INFO.xml' path='doc/member[@name="WIA_DATA_TRANSFER_INFO"]/*' />
public partial struct WIA_DATA_TRANSFER_INFO
{
    /// <include file='WIA_DATA_TRANSFER_INFO.xml' path='doc/member[@name="WIA_DATA_TRANSFER_INFO.ulSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSize;

    /// <include file='WIA_DATA_TRANSFER_INFO.xml' path='doc/member[@name="WIA_DATA_TRANSFER_INFO.ulSection"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSection;

    /// <include file='WIA_DATA_TRANSFER_INFO.xml' path='doc/member[@name="WIA_DATA_TRANSFER_INFO.ulBufferSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulBufferSize;

    /// <include file='WIA_DATA_TRANSFER_INFO.xml' path='doc/member[@name="WIA_DATA_TRANSFER_INFO.bDoubleBuffer"]/*' />
    public BOOL bDoubleBuffer;

    /// <include file='WIA_DATA_TRANSFER_INFO.xml' path='doc/member[@name="WIA_DATA_TRANSFER_INFO.ulReserved1"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulReserved1;

    /// <include file='WIA_DATA_TRANSFER_INFO.xml' path='doc/member[@name="WIA_DATA_TRANSFER_INFO.ulReserved2"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulReserved2;

    /// <include file='WIA_DATA_TRANSFER_INFO.xml' path='doc/member[@name="WIA_DATA_TRANSFER_INFO.ulReserved3"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulReserved3;
}
