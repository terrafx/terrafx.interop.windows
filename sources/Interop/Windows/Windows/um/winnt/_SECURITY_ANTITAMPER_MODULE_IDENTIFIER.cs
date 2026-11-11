// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ANTITAMPER_MODULE_IDENTIFIER.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_MODULE_IDENTIFIER"]/*' />
public unsafe partial struct _SECURITY_ANTITAMPER_MODULE_IDENTIFIER
{
    /// <include file='_SECURITY_ANTITAMPER_MODULE_IDENTIFIER.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_MODULE_IDENTIFIER.Type"]/*' />
    [NativeTypeName("SECURITY_ANTITAMPER_MODULE_IDENTIFIER_TYPE")]
    public _SECURITY_ANTITAMPER_MODULE_IDENTIFIER_TYPE Type;

    /// <include file='_SECURITY_ANTITAMPER_MODULE_IDENTIFIER.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_MODULE_IDENTIFIER.DataSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataSize;

    /// <include file='_SECURITY_ANTITAMPER_MODULE_IDENTIFIER.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_MODULE_IDENTIFIER.Data"]/*' />
    [NativeTypeName("PBYTE")]
    public byte* Data;
}
