// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO"]/*' />
public partial struct WIM_PROVIDER_EXTERNAL_INFO
{
    /// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO.DataSourceId"]/*' />
    public LARGE_INTEGER DataSourceId;

    /// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO.ResourceHash"]/*' />
    [NativeTypeName("BYTE[20]")]
    public _ResourceHash_e__FixedBuffer ResourceHash;

    /// <include file='_ResourceHash_e__FixedBuffer.xml' path='doc/member[@name="_ResourceHash_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _ResourceHash_e__FixedBuffer
    {
        public byte e0;
    }
}
