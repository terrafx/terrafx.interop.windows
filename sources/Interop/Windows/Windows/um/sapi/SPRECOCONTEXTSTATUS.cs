// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS"]/*' />
public partial struct SPRECOCONTEXTSTATUS
{
    /// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS.eInterference"]/*' />
    public SPINTERFERENCE eInterference;

    /// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS.szRequestTypeOfUI"]/*' />
    [NativeTypeName("WCHAR[255]")]
    public _szRequestTypeOfUI_e__FixedBuffer szRequestTypeOfUI;

    /// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS.dwReserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved2;

    /// <include file='_szRequestTypeOfUI_e__FixedBuffer.xml' path='doc/member[@name="_szRequestTypeOfUI_e__FixedBuffer"]/*' />
    [InlineArray(255)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szRequestTypeOfUI_e__FixedBuffer
    {
        public char e0;
    }
}
