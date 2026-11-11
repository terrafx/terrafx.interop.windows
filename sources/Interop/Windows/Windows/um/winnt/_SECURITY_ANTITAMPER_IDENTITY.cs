// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ANTITAMPER_IDENTITY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_IDENTITY"]/*' />
public unsafe partial struct _SECURITY_ANTITAMPER_IDENTITY
{
    /// <include file='_SECURITY_ANTITAMPER_IDENTITY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_IDENTITY.Name"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Name;

    /// <include file='_SECURITY_ANTITAMPER_IDENTITY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_IDENTITY.Publisher"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* Publisher;
}
