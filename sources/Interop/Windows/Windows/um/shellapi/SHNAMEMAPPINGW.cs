// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SHNAMEMAPPINGW.xml' path='doc/member[@name="SHNAMEMAPPINGW"]/*' />
public unsafe partial struct SHNAMEMAPPINGW
{
    /// <include file='SHNAMEMAPPINGW.xml' path='doc/member[@name="SHNAMEMAPPINGW.pszOldPath"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszOldPath;

    /// <include file='SHNAMEMAPPINGW.xml' path='doc/member[@name="SHNAMEMAPPINGW.pszNewPath"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszNewPath;

    /// <include file='SHNAMEMAPPINGW.xml' path='doc/member[@name="SHNAMEMAPPINGW.cchOldPath"]/*' />
    public int cchOldPath;

    /// <include file='SHNAMEMAPPINGW.xml' path='doc/member[@name="SHNAMEMAPPINGW.cchNewPath"]/*' />
    public int cchNewPath;
}
