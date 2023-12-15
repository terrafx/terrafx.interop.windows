// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW"]/*' />
public unsafe partial struct SRCCODEINFOW
{
    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.Key"]/*' />
    [NativeTypeName("PVOID")]
    public void* Key;

    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.ModBase"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong ModBase;

    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.Obj"]/*' />
    [NativeTypeName("WCHAR[261]")]
    public _Obj_e__FixedBuffer Obj;

    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.FileName"]/*' />
    [NativeTypeName("WCHAR[261]")]
    public _FileName_e__FixedBuffer FileName;

    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.LineNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint LineNumber;

    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.Address"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Address;

    /// <include file='_Obj_e__FixedBuffer.xml' path='doc/member[@name="_Obj_e__FixedBuffer"]/*' />
    [InlineArray(261)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _Obj_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_FileName_e__FixedBuffer.xml' path='doc/member[@name="_FileName_e__FixedBuffer"]/*' />
    [InlineArray(261)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _FileName_e__FixedBuffer
    {
        public char e0;
    }
}
