// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProcessorArchitecture.xml' path='doc/member[@name="ProcessorArchitecture"]/*' />
public enum ProcessorArchitecture
{
    /// <include file='ProcessorArchitecture.xml' path='doc/member[@name="ProcessorArchitecture.ProcessorArchitecture_X86"]/*' />
    ProcessorArchitecture_X86 = 0,

    /// <include file='ProcessorArchitecture.xml' path='doc/member[@name="ProcessorArchitecture.ProcessorArchitecture_Arm"]/*' />
    ProcessorArchitecture_Arm = 5,

    /// <include file='ProcessorArchitecture.xml' path='doc/member[@name="ProcessorArchitecture.ProcessorArchitecture_X64"]/*' />
    ProcessorArchitecture_X64 = 9,

    /// <include file='ProcessorArchitecture.xml' path='doc/member[@name="ProcessorArchitecture.ProcessorArchitecture_Neutral"]/*' />
    ProcessorArchitecture_Neutral = 11,

    /// <include file='ProcessorArchitecture.xml' path='doc/member[@name="ProcessorArchitecture.ProcessorArchitecture_Arm64"]/*' />
    ProcessorArchitecture_Arm64 = 12,

    /// <include file='ProcessorArchitecture.xml' path='doc/member[@name="ProcessorArchitecture.ProcessorArchitecture_X86OnArm64"]/*' />
    ProcessorArchitecture_X86OnArm64 = 14,

    /// <include file='ProcessorArchitecture.xml' path='doc/member[@name="ProcessorArchitecture.ProcessorArchitecture_Unknown"]/*' />
    ProcessorArchitecture_Unknown = 65535,
}
