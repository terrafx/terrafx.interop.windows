// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MseReadyState.xml' path='doc/member[@name="MseReadyState"]/*' />
public enum MseReadyState
{
    /// <include file='MseReadyState.xml' path='doc/member[@name="MseReadyState.MseReadyState_Closed"]/*' />
    MseReadyState_Closed = 0,

    /// <include file='MseReadyState.xml' path='doc/member[@name="MseReadyState.MseReadyState_Open"]/*' />
    MseReadyState_Open = 1,

    /// <include file='MseReadyState.xml' path='doc/member[@name="MseReadyState.MseReadyState_Ended"]/*' />
    MseReadyState_Ended = 2,
}
