// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ASSOCIATIONELEMENT.xml' path='doc/member[@name="ASSOCIATIONELEMENT"]/*' />
public unsafe partial struct ASSOCIATIONELEMENT
{
    /// <include file='ASSOCIATIONELEMENT.xml' path='doc/member[@name="ASSOCIATIONELEMENT.ac"]/*' />
    public ASSOCCLASS ac;

    /// <include file='ASSOCIATIONELEMENT.xml' path='doc/member[@name="ASSOCIATIONELEMENT.hkClass"]/*' />
    public HKEY hkClass;

    /// <include file='ASSOCIATIONELEMENT.xml' path='doc/member[@name="ASSOCIATIONELEMENT.pszClass"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pszClass;
}
