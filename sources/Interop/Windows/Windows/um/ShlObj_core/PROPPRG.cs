// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PROPPRG
{
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.flPrg"]/*' />
    [NativeTypeName("WORD")]
    public ushort flPrg;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.flPrgInit"]/*' />
    [NativeTypeName("WORD")]
    public ushort flPrgInit;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achTitle"]/*' />
    [NativeTypeName("CHAR[30]")]
    public _achTitle_e__FixedBuffer achTitle;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achCmdLine"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _achCmdLine_e__FixedBuffer achCmdLine;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achWorkDir"]/*' />
    [NativeTypeName("CHAR[64]")]
    public _achWorkDir_e__FixedBuffer achWorkDir;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.wHotKey"]/*' />
    [NativeTypeName("WORD")]
    public ushort wHotKey;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achIconFile"]/*' />
    [NativeTypeName("CHAR[80]")]
    public _achIconFile_e__FixedBuffer achIconFile;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.wIconIndex"]/*' />
    [NativeTypeName("WORD")]
    public ushort wIconIndex;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.dwEnhModeFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEnhModeFlags;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.dwRealModeFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRealModeFlags;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achOtherFile"]/*' />
    [NativeTypeName("CHAR[80]")]
    public _achOtherFile_e__FixedBuffer achOtherFile;

    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achPIFFile"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _achPIFFile_e__FixedBuffer achPIFFile;

    /// <include file='_achTitle_e__FixedBuffer.xml' path='doc/member[@name="_achTitle_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(30)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _achTitle_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_achCmdLine_e__FixedBuffer.xml' path='doc/member[@name="_achCmdLine_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _achCmdLine_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_achWorkDir_e__FixedBuffer.xml' path='doc/member[@name="_achWorkDir_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _achWorkDir_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_achIconFile_e__FixedBuffer.xml' path='doc/member[@name="_achIconFile_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(80)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _achIconFile_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_achOtherFile_e__FixedBuffer.xml' path='doc/member[@name="_achOtherFile_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(80)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _achOtherFile_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_achPIFFile_e__FixedBuffer.xml' path='doc/member[@name="_achPIFFile_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _achPIFFile_e__FixedBuffer
    {
        public sbyte e0;
    }
}
