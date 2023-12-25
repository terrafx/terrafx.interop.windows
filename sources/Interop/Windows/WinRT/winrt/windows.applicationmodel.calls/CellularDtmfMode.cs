// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CellularDtmfMode.xml' path='doc/member[@name="CellularDtmfMode"]/*' />
public enum CellularDtmfMode
{
    /// <include file='CellularDtmfMode.xml' path='doc/member[@name="CellularDtmfMode.CellularDtmfMode_Continuous"]/*' />
    CellularDtmfMode_Continuous = 0,

    /// <include file='CellularDtmfMode.xml' path='doc/member[@name="CellularDtmfMode.CellularDtmfMode_Burst"]/*' />
    CellularDtmfMode_Burst = 1,
}
