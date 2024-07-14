// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='QuantumSizeSelectionMode.xml' path='doc/member[@name="QuantumSizeSelectionMode"]/*' />
public enum QuantumSizeSelectionMode
{
    /// <include file='QuantumSizeSelectionMode.xml' path='doc/member[@name="QuantumSizeSelectionMode.QuantumSizeSelectionMode_SystemDefault"]/*' />
    QuantumSizeSelectionMode_SystemDefault = 0,

    /// <include file='QuantumSizeSelectionMode.xml' path='doc/member[@name="QuantumSizeSelectionMode.QuantumSizeSelectionMode_LowestLatency"]/*' />
    QuantumSizeSelectionMode_LowestLatency = 1,

    /// <include file='QuantumSizeSelectionMode.xml' path='doc/member[@name="QuantumSizeSelectionMode.QuantumSizeSelectionMode_ClosestToDesired"]/*' />
    QuantumSizeSelectionMode_ClosestToDesired = 2,
}
