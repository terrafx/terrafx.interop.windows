// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundWorkCostValue.xml' path='doc/member[@name="BackgroundWorkCostValue"]/*' />
public enum BackgroundWorkCostValue
{
    /// <include file='BackgroundWorkCostValue.xml' path='doc/member[@name="BackgroundWorkCostValue.BackgroundWorkCostValue_Low"]/*' />
    BackgroundWorkCostValue_Low = 0,

    /// <include file='BackgroundWorkCostValue.xml' path='doc/member[@name="BackgroundWorkCostValue.BackgroundWorkCostValue_Medium"]/*' />
    BackgroundWorkCostValue_Medium = 1,

    /// <include file='BackgroundWorkCostValue.xml' path='doc/member[@name="BackgroundWorkCostValue.BackgroundWorkCostValue_High"]/*' />
    BackgroundWorkCostValue_High = 2,
}
