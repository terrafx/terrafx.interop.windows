// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.metadata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GCPressureAmount.xml' path='doc/member[@name="GCPressureAmount"]/*' />
public enum GCPressureAmount
{
    /// <include file='GCPressureAmount.xml' path='doc/member[@name="GCPressureAmount.GCPressureAmount_Low"]/*' />
    GCPressureAmount_Low = 0,

    /// <include file='GCPressureAmount.xml' path='doc/member[@name="GCPressureAmount.GCPressureAmount_Medium"]/*' />
    GCPressureAmount_Medium = 1,

    /// <include file='GCPressureAmount.xml' path='doc/member[@name="GCPressureAmount.GCPressureAmount_High"]/*' />
    GCPressureAmount_High = 2,
}
