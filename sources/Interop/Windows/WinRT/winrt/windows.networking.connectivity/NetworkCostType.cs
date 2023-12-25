// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NetworkCostType.xml' path='doc/member[@name="NetworkCostType"]/*' />
public enum NetworkCostType
{
    /// <include file='NetworkCostType.xml' path='doc/member[@name="NetworkCostType.NetworkCostType_Unknown"]/*' />
    NetworkCostType_Unknown = 0,

    /// <include file='NetworkCostType.xml' path='doc/member[@name="NetworkCostType.NetworkCostType_Unrestricted"]/*' />
    NetworkCostType_Unrestricted = 1,

    /// <include file='NetworkCostType.xml' path='doc/member[@name="NetworkCostType.NetworkCostType_Fixed"]/*' />
    NetworkCostType_Fixed = 2,

    /// <include file='NetworkCostType.xml' path='doc/member[@name="NetworkCostType.NetworkCostType_Variable"]/*' />
    NetworkCostType_Variable = 3,
}
