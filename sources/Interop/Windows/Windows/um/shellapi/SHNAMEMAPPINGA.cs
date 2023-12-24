// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SHNAMEMAPPINGA.xml' path='doc/member[@name="SHNAMEMAPPINGA"]/*' />
public unsafe partial struct SHNAMEMAPPINGA
{
    /// <include file='SHNAMEMAPPINGA.xml' path='doc/member[@name="SHNAMEMAPPINGA.pszOldPath"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszOldPath;

    /// <include file='SHNAMEMAPPINGA.xml' path='doc/member[@name="SHNAMEMAPPINGA.pszNewPath"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszNewPath;

    /// <include file='SHNAMEMAPPINGA.xml' path='doc/member[@name="SHNAMEMAPPINGA.cchOldPath"]/*' />
    public int cchOldPath;

    /// <include file='SHNAMEMAPPINGA.xml' path='doc/member[@name="SHNAMEMAPPINGA.cchNewPath"]/*' />
    public int cchNewPath;
}
