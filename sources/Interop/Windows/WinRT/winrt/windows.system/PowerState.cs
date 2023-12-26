// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PowerState.xml' path='doc/member[@name="PowerState"]/*' />
public enum PowerState
{
    /// <include file='PowerState.xml' path='doc/member[@name="PowerState.PowerState_ConnectedStandby"]/*' />
    PowerState_ConnectedStandby = 0,

    /// <include file='PowerState.xml' path='doc/member[@name="PowerState.PowerState_SleepS3"]/*' />
    PowerState_SleepS3 = 1,
}
