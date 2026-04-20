// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.xml' path='doc/member[@name="IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON"]/*' />
public partial struct IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON
{
    /// <include file='IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.xml' path='doc/member[@name="IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.xml' path='doc/member[@name="IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.Rva"]/*' />
    [NativeTypeName("DWORD")]
    public uint Rva;

    /// <include file='IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.xml' path='doc/member[@name="IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.NameSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint NameSize;

    /// <include file='IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.xml' path='doc/member[@name="IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON.NameOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NameOffset;
}
