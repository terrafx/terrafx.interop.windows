// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WIA_EXTENDED_TRANSFER_INFO.xml' path='doc/member[@name="WIA_EXTENDED_TRANSFER_INFO"]/*' />
public partial struct WIA_EXTENDED_TRANSFER_INFO
{
    /// <include file='WIA_EXTENDED_TRANSFER_INFO.xml' path='doc/member[@name="WIA_EXTENDED_TRANSFER_INFO.ulSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSize;

    /// <include file='WIA_EXTENDED_TRANSFER_INFO.xml' path='doc/member[@name="WIA_EXTENDED_TRANSFER_INFO.ulMinBufferSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulMinBufferSize;

    /// <include file='WIA_EXTENDED_TRANSFER_INFO.xml' path='doc/member[@name="WIA_EXTENDED_TRANSFER_INFO.ulOptimalBufferSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulOptimalBufferSize;

    /// <include file='WIA_EXTENDED_TRANSFER_INFO.xml' path='doc/member[@name="WIA_EXTENDED_TRANSFER_INFO.ulMaxBufferSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulMaxBufferSize;

    /// <include file='WIA_EXTENDED_TRANSFER_INFO.xml' path='doc/member[@name="WIA_EXTENDED_TRANSFER_INFO.ulNumBuffers"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulNumBuffers;
}
