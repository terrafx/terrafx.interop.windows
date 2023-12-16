// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_REQUEST_STATS.xml' path='doc/member[@name="WINHTTP_REQUEST_STATS"]/*' />
[SupportedOSPlatform("windows10.0.18362.0")]
public partial struct WINHTTP_REQUEST_STATS
{
    /// <include file='WINHTTP_REQUEST_STATS.xml' path='doc/member[@name="WINHTTP_REQUEST_STATS.ullFlags"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;

    /// <include file='WINHTTP_REQUEST_STATS.xml' path='doc/member[@name="WINHTTP_REQUEST_STATS.ulIndex"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulIndex;

    /// <include file='WINHTTP_REQUEST_STATS.xml' path='doc/member[@name="WINHTTP_REQUEST_STATS.cStats"]/*' />
    [NativeTypeName("ULONG")]
    public uint cStats;

    /// <include file='WINHTTP_REQUEST_STATS.xml' path='doc/member[@name="WINHTTP_REQUEST_STATS.rgullStats"]/*' />
    [NativeTypeName("ULONGLONG[32]")]
    public _rgullStats_e__FixedBuffer rgullStats;

    /// <include file='_rgullStats_e__FixedBuffer.xml' path='doc/member[@name="_rgullStats_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _rgullStats_e__FixedBuffer
    {
        public ulong e0;
    }
}
