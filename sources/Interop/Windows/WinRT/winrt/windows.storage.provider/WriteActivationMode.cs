// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WriteActivationMode.xml' path='doc/member[@name="WriteActivationMode"]/*' />
public enum WriteActivationMode
{
    /// <include file='WriteActivationMode.xml' path='doc/member[@name="WriteActivationMode.WriteActivationMode_ReadOnly"]/*' />
    WriteActivationMode_ReadOnly = 0,

    /// <include file='WriteActivationMode.xml' path='doc/member[@name="WriteActivationMode.WriteActivationMode_NotNeeded"]/*' />
    WriteActivationMode_NotNeeded = 1,

    /// <include file='WriteActivationMode.xml' path='doc/member[@name="WriteActivationMode.WriteActivationMode_AfterWrite"]/*' />
    WriteActivationMode_AfterWrite = 2,
}
