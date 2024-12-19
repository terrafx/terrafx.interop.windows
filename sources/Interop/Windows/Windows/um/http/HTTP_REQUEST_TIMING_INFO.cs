// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_TIMING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_INFO"]/*' />
public partial struct HTTP_REQUEST_TIMING_INFO
{
    /// <include file='HTTP_REQUEST_TIMING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_INFO.RequestTimingCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint RequestTimingCount;

    /// <include file='HTTP_REQUEST_TIMING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_TIMING_INFO.RequestTiming"]/*' />
    [NativeTypeName("ULONGLONG[30]")]
    public _RequestTiming_e__FixedBuffer RequestTiming;

    /// <include file='_RequestTiming_e__FixedBuffer.xml' path='doc/member[@name="_RequestTiming_e__FixedBuffer"]/*' />
    [InlineArray(30)]
    public partial struct _RequestTiming_e__FixedBuffer
    {
        public ulong e0;
    }
}
