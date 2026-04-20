// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_HOTSWAP_ENDPOINT_INFO_HEADER_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_ENDPOINT_INFO_HEADER_V2"]/*' />
public partial struct IMAGE_HOTSWAP_ENDPOINT_INFO_HEADER_V2
{
    /// <include file='IMAGE_HOTSWAP_ENDPOINT_INFO_HEADER_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_ENDPOINT_INFO_HEADER_V2.Common"]/*' />
    public IMAGE_HOTSWAP_ENDPOINT_INFO_HEADER_COMMON Common;

    /// <include file='IMAGE_HOTSWAP_ENDPOINT_INFO_HEADER_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_ENDPOINT_INFO_HEADER_V2.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;
}
