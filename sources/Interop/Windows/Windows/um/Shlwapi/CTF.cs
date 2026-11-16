// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CTF
{
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_INSIST"]/*' />
    public const int CTF_INSIST = 0x00000001;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_THREAD_REF"]/*' />
    public const int CTF_THREAD_REF = 0x00000002;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_PROCESS_REF"]/*' />
    public const int CTF_PROCESS_REF = 0x00000004;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_COINIT_STA"]/*' />
    public const int CTF_COINIT_STA = 0x00000008;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_COINIT"]/*' />
    public const int CTF_COINIT = 0x00000008;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_FREELIBANDEXIT"]/*' />
    public const int CTF_FREELIBANDEXIT = 0x00000010;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_REF_COUNTED"]/*' />
    public const int CTF_REF_COUNTED = 0x00000020;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_WAIT_ALLOWCOM"]/*' />
    public const int CTF_WAIT_ALLOWCOM = 0x00000040;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_UNUSED"]/*' />
    public const int CTF_UNUSED = 0x00000080;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_INHERITWOW64"]/*' />
    public const int CTF_INHERITWOW64 = 0x00000100;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_WAIT_NO_REENTRANCY"]/*' />
    public const int CTF_WAIT_NO_REENTRANCY = 0x00000200;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_KEYBOARD_LOCALE"]/*' />
    public const int CTF_KEYBOARD_LOCALE = 0x00000400;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_OLEINITIALIZE"]/*' />
    public const int CTF_OLEINITIALIZE = 0x00000800;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_COINIT_MTA"]/*' />
    public const int CTF_COINIT_MTA = 0x00001000;
    /// <include file='CTF.xml' path='doc/member[@name="CTF.CTF_NOADDREFLIB"]/*' />
    public const int CTF_NOADDREFLIB = 0x00002000;
}
