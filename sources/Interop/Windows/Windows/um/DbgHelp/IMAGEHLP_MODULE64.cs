// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64"]/*' />
public partial struct IMAGEHLP_MODULE64
{
    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.BaseOfImage"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong BaseOfImage;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.ImageSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImageSize;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.CheckSum"]/*' />
    [NativeTypeName("DWORD")]
    public uint CheckSum;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.NumSyms"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumSyms;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.SymType"]/*' />
    public SYM_TYPE SymType;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.ModuleName"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _ModuleName_e__FixedBuffer ModuleName;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.ImageName"]/*' />
    [NativeTypeName("CHAR[256]")]
    public _ImageName_e__FixedBuffer ImageName;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.LoadedImageName"]/*' />
    [NativeTypeName("CHAR[256]")]
    public _LoadedImageName_e__FixedBuffer LoadedImageName;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.LoadedPdbName"]/*' />
    [NativeTypeName("CHAR[256]")]
    public _LoadedPdbName_e__FixedBuffer LoadedPdbName;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.CVSig"]/*' />
    [NativeTypeName("DWORD")]
    public uint CVSig;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.CVData"]/*' />
    [NativeTypeName("CHAR[780]")]
    public _CVData_e__FixedBuffer CVData;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.PdbSig"]/*' />
    [NativeTypeName("DWORD")]
    public uint PdbSig;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.PdbSig70"]/*' />
    public Guid PdbSig70;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.PdbAge"]/*' />
    [NativeTypeName("DWORD")]
    public uint PdbAge;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.PdbUnmatched"]/*' />
    public BOOL PdbUnmatched;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.DbgUnmatched"]/*' />
    public BOOL DbgUnmatched;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.LineNumbers"]/*' />
    public BOOL LineNumbers;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.GlobalSymbols"]/*' />
    public BOOL GlobalSymbols;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.TypeInfo"]/*' />
    public BOOL TypeInfo;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.SourceIndexed"]/*' />
    public BOOL SourceIndexed;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.Publics"]/*' />
    public BOOL Publics;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.MachineType"]/*' />
    [NativeTypeName("DWORD")]
    public uint MachineType;

    /// <include file='IMAGEHLP_MODULE64.xml' path='doc/member[@name="IMAGEHLP_MODULE64.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='_ModuleName_e__FixedBuffer.xml' path='doc/member[@name="_ModuleName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _ModuleName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_ImageName_e__FixedBuffer.xml' path='doc/member[@name="_ImageName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _ImageName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_LoadedImageName_e__FixedBuffer.xml' path='doc/member[@name="_LoadedImageName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _LoadedImageName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_LoadedPdbName_e__FixedBuffer.xml' path='doc/member[@name="_LoadedPdbName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _LoadedPdbName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_CVData_e__FixedBuffer.xml' path='doc/member[@name="_CVData_e__FixedBuffer"]/*' />
    [InlineArray(780)]
    public partial struct _CVData_e__FixedBuffer
    {
        public sbyte e0;
    }
}
