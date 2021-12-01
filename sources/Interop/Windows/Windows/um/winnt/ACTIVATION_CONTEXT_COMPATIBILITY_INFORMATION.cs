// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION"]/*' />
public partial struct ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION
{
    /// <include file='ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.ElementCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ElementCount;

    /// <include file='ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.Elements"]/*' />
    [NativeTypeName("COMPATIBILITY_CONTEXT_ELEMENT []")]
    public COMPATIBILITY_CONTEXT_ELEMENT Elements;
}
