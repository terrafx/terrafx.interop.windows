// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundTaskThrottleCounter.xml' path='doc/member[@name="BackgroundTaskThrottleCounter"]/*' />
public enum BackgroundTaskThrottleCounter
{
    /// <include file='BackgroundTaskThrottleCounter.xml' path='doc/member[@name="BackgroundTaskThrottleCounter.BackgroundTaskThrottleCounter_All"]/*' />
    BackgroundTaskThrottleCounter_All = 0,

    /// <include file='BackgroundTaskThrottleCounter.xml' path='doc/member[@name="BackgroundTaskThrottleCounter.BackgroundTaskThrottleCounter_Cpu"]/*' />
    BackgroundTaskThrottleCounter_Cpu = 1,

    /// <include file='BackgroundTaskThrottleCounter.xml' path='doc/member[@name="BackgroundTaskThrottleCounter.BackgroundTaskThrottleCounter_Network"]/*' />
    BackgroundTaskThrottleCounter_Network = 2,
}
