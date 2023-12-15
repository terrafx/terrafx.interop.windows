// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SRCCODEINFO.xml' path='doc/member[@name="SRCCODEINFO"]/*' />
public unsafe partial struct SRCCODEINFO
{
    /// <include file='SRCCODEINFO.xml' path='doc/member[@name="SRCCODEINFO.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='SRCCODEINFO.xml' path='doc/member[@name="SRCCODEINFO.Key"]/*' />
    [NativeTypeName("PVOID")]
    public void* Key;

    /// <include file='SRCCODEINFO.xml' path='doc/member[@name="SRCCODEINFO.ModBase"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong ModBase;

    /// <include file='SRCCODEINFO.xml' path='doc/member[@name="SRCCODEINFO.Obj"]/*' />
    [NativeTypeName("CHAR[261]")]
    public _Obj_e__FixedBuffer Obj;

    /// <include file='SRCCODEINFO.xml' path='doc/member[@name="SRCCODEINFO.FileName"]/*' />
    [NativeTypeName("CHAR[261]")]
    public _FileName_e__FixedBuffer FileName;

    /// <include file='SRCCODEINFO.xml' path='doc/member[@name="SRCCODEINFO.LineNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint LineNumber;

    /// <include file='SRCCODEINFO.xml' path='doc/member[@name="SRCCODEINFO.Address"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Address;

    /// <include file='_Obj_e__FixedBuffer.xml' path='doc/member[@name="_Obj_e__FixedBuffer"]/*' />
    [InlineArray(261)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _Obj_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_FileName_e__FixedBuffer.xml' path='doc/member[@name="_FileName_e__FixedBuffer"]/*' />
    [InlineArray(261)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _FileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
