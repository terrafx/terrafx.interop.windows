// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ReadActivationMode.xml' path='doc/member[@name="ReadActivationMode"]/*' />
public enum ReadActivationMode
{
    /// <include file='ReadActivationMode.xml' path='doc/member[@name="ReadActivationMode.ReadActivationMode_NotNeeded"]/*' />
    ReadActivationMode_NotNeeded = 0,

    /// <include file='ReadActivationMode.xml' path='doc/member[@name="ReadActivationMode.ReadActivationMode_BeforeAccess"]/*' />
    ReadActivationMode_BeforeAccess = 1,
}
