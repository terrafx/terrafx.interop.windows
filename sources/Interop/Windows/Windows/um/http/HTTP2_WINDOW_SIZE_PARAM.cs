// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP2_WINDOW_SIZE_PARAM.xml' path='doc/member[@name="HTTP2_WINDOW_SIZE_PARAM"]/*' />
public partial struct HTTP2_WINDOW_SIZE_PARAM
{
    /// <include file='HTTP2_WINDOW_SIZE_PARAM.xml' path='doc/member[@name="HTTP2_WINDOW_SIZE_PARAM.Http2ReceiveWindowSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint Http2ReceiveWindowSize;
}
