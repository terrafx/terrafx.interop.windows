// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW"]/*' />
public partial struct IMAGEHLP_MODULEW
{
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.BaseOfImage"]/*' />
    [NativeTypeName("DWORD")]
    public uint BaseOfImage;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.ImageSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImageSize;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.CheckSum"]/*' />
    [NativeTypeName("DWORD")]
    public uint CheckSum;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.NumSyms"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumSyms;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.SymType"]/*' />
    public SYM_TYPE SymType;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.ModuleName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _ModuleName_e__FixedBuffer ModuleName;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.ImageName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _ImageName_e__FixedBuffer ImageName;

    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.LoadedImageName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _LoadedImageName_e__FixedBuffer LoadedImageName;

    /// <include file='_ModuleName_e__FixedBuffer.xml' path='doc/member[@name="_ModuleName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _ModuleName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_ImageName_e__FixedBuffer.xml' path='doc/member[@name="_ImageName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _ImageName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_LoadedImageName_e__FixedBuffer.xml' path='doc/member[@name="_LoadedImageName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _LoadedImageName_e__FixedBuffer
    {
        public char e0;
    }
}
