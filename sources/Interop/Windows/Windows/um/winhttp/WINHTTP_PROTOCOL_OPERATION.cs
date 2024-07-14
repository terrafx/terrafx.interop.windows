// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_PROTOCOL_OPERATION.xml' path='doc/member[@name="WINHTTP_PROTOCOL_OPERATION"]/*' />
public enum WINHTTP_PROTOCOL_OPERATION
{
    /// <include file='WINHTTP_PROTOCOL_OPERATION.xml' path='doc/member[@name="WINHTTP_PROTOCOL_OPERATION.WINHTTP_PROTOCOL_SEND_OPERATION"]/*' />
    WINHTTP_PROTOCOL_SEND_OPERATION = 0,

    /// <include file='WINHTTP_PROTOCOL_OPERATION.xml' path='doc/member[@name="WINHTTP_PROTOCOL_OPERATION.WINHTTP_PROTOCOL_RECEIVE_OPERATION"]/*' />
    WINHTTP_PROTOCOL_RECEIVE_OPERATION = 1,
}
