// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_PROPERTY_STREAM_ERROR.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY_STREAM_ERROR"]/*' />
public partial struct HTTP_REQUEST_PROPERTY_STREAM_ERROR
{
    /// <include file='HTTP_REQUEST_PROPERTY_STREAM_ERROR.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY_STREAM_ERROR.ErrorCode"]/*' />
    [NativeTypeName("ULONG")]
    public uint ErrorCode;
}
