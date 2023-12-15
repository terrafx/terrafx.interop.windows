// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYMSRV_EXTENDED_OUTPUT_DATA.xml' path='doc/member[@name="SYMSRV_EXTENDED_OUTPUT_DATA"]/*' />
public partial struct SYMSRV_EXTENDED_OUTPUT_DATA
{
    /// <include file='SYMSRV_EXTENDED_OUTPUT_DATA.xml' path='doc/member[@name="SYMSRV_EXTENDED_OUTPUT_DATA.sizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint sizeOfStruct;

    /// <include file='SYMSRV_EXTENDED_OUTPUT_DATA.xml' path='doc/member[@name="SYMSRV_EXTENDED_OUTPUT_DATA.version"]/*' />
    [NativeTypeName("DWORD")]
    public uint version;

    /// <include file='SYMSRV_EXTENDED_OUTPUT_DATA.xml' path='doc/member[@name="SYMSRV_EXTENDED_OUTPUT_DATA.filePtrMsg"]/*' />
    [NativeTypeName("WCHAR[261]")]
    public _filePtrMsg_e__FixedBuffer filePtrMsg;

    /// <include file='_filePtrMsg_e__FixedBuffer.xml' path='doc/member[@name="_filePtrMsg_e__FixedBuffer"]/*' />
    [InlineArray(261)]
    public partial struct _filePtrMsg_e__FixedBuffer
    {
        public char e0;
    }
}
