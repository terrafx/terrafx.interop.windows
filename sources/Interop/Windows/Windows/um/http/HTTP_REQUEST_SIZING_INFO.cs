// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_SIZING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_INFO"]/*' />
public partial struct HTTP_REQUEST_SIZING_INFO
{
    /// <include file='HTTP_REQUEST_SIZING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_INFO.Flags"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong Flags;

    /// <include file='HTTP_REQUEST_SIZING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_INFO.RequestIndex"]/*' />
    [NativeTypeName("ULONG")]
    public uint RequestIndex;

    /// <include file='HTTP_REQUEST_SIZING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_INFO.RequestSizingCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint RequestSizingCount;

    /// <include file='HTTP_REQUEST_SIZING_INFO.xml' path='doc/member[@name="HTTP_REQUEST_SIZING_INFO.RequestSizing"]/*' />
    [NativeTypeName("ULONGLONG[5]")]
    public _RequestSizing_e__FixedBuffer RequestSizing;

    /// <include file='_RequestSizing_e__FixedBuffer.xml' path='doc/member[@name="_RequestSizing_e__FixedBuffer"]/*' />
    [InlineArray(5)]
    public partial struct _RequestSizing_e__FixedBuffer
    {
        public ulong e0;
    }
}
