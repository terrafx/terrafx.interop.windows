// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_REQUEST_TIMES.xml' path='doc/member[@name="WINHTTP_REQUEST_TIMES"]/*' />
[SupportedOSPlatform("windows10.0.18362.0")]
public partial struct WINHTTP_REQUEST_TIMES
{
    /// <include file='WINHTTP_REQUEST_TIMES.xml' path='doc/member[@name="WINHTTP_REQUEST_TIMES.cTimes"]/*' />
    [NativeTypeName("ULONG")]
    public uint cTimes;

    /// <include file='WINHTTP_REQUEST_TIMES.xml' path='doc/member[@name="WINHTTP_REQUEST_TIMES.rgullTimes"]/*' />
    [NativeTypeName("ULONGLONG[64]")]
    public _rgullTimes_e__FixedBuffer rgullTimes;

    /// <include file='_rgullTimes_e__FixedBuffer.xml' path='doc/member[@name="_rgullTimes_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _rgullTimes_e__FixedBuffer
    {
        public ulong e0;
    }
}
