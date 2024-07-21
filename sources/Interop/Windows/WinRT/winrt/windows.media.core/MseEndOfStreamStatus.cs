// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MseEndOfStreamStatus.xml' path='doc/member[@name="MseEndOfStreamStatus"]/*' />
public enum MseEndOfStreamStatus
{
    /// <include file='MseEndOfStreamStatus.xml' path='doc/member[@name="MseEndOfStreamStatus.MseEndOfStreamStatus_Success"]/*' />
    MseEndOfStreamStatus_Success = 0,

    /// <include file='MseEndOfStreamStatus.xml' path='doc/member[@name="MseEndOfStreamStatus.MseEndOfStreamStatus_NetworkError"]/*' />
    MseEndOfStreamStatus_NetworkError = 1,

    /// <include file='MseEndOfStreamStatus.xml' path='doc/member[@name="MseEndOfStreamStatus.MseEndOfStreamStatus_DecodeError"]/*' />
    MseEndOfStreamStatus_DecodeError = 2,

    /// <include file='MseEndOfStreamStatus.xml' path='doc/member[@name="MseEndOfStreamStatus.MseEndOfStreamStatus_UnknownError"]/*' />
    MseEndOfStreamStatus_UnknownError = 3,
}
