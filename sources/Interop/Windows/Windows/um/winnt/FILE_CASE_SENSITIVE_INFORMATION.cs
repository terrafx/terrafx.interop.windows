// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILE_CASE_SENSITIVE_INFORMATION.xml' path='doc/member[@name="FILE_CASE_SENSITIVE_INFORMATION"]/*' />
public partial struct FILE_CASE_SENSITIVE_INFORMATION
{
    /// <include file='FILE_CASE_SENSITIVE_INFORMATION.xml' path='doc/member[@name="FILE_CASE_SENSITIVE_INFORMATION.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
