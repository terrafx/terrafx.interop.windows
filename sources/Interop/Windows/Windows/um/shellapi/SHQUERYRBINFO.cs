// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SHQUERYRBINFO.xml' path='doc/member[@name="SHQUERYRBINFO"]/*' />
public partial struct SHQUERYRBINFO
{
    /// <include file='SHQUERYRBINFO.xml' path='doc/member[@name="SHQUERYRBINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SHQUERYRBINFO.xml' path='doc/member[@name="SHQUERYRBINFO.i64Size"]/*' />
    [NativeTypeName("long long")]
    public long i64Size;

    /// <include file='SHQUERYRBINFO.xml' path='doc/member[@name="SHQUERYRBINFO.i64NumItems"]/*' />
    [NativeTypeName("long long")]
    public long i64NumItems;
}
