// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SetFileNameResult.xml' path='doc/member[@name="SetFileNameResult"]/*' />
public enum SetFileNameResult
{
    /// <include file='SetFileNameResult.xml' path='doc/member[@name="SetFileNameResult.SetFileNameResult_Succeeded"]/*' />
    SetFileNameResult_Succeeded = 0,

    /// <include file='SetFileNameResult.xml' path='doc/member[@name="SetFileNameResult.SetFileNameResult_NotAllowed"]/*' />
    SetFileNameResult_NotAllowed = 1,

    /// <include file='SetFileNameResult.xml' path='doc/member[@name="SetFileNameResult.SetFileNameResult_Unavailable"]/*' />
    SetFileNameResult_Unavailable = 2,
}
