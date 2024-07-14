// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W"]/*' />
public partial struct SP_DRVINFO_DETAIL_DATA_W
{
    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.InfDate"]/*' />
    public FILETIME InfDate;

    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.CompatIDsOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint CompatIDsOffset;

    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.CompatIDsLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint CompatIDsLength;

    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.Reserved"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;

    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.SectionName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _SectionName_e__FixedBuffer SectionName;

    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.InfFileName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _InfFileName_e__FixedBuffer InfFileName;

    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.DrvDescription"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _DrvDescription_e__FixedBuffer DrvDescription;

    /// <include file='SP_DRVINFO_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DRVINFO_DETAIL_DATA_W.HardwareID"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _HardwareID_e__FixedBuffer HardwareID;

    /// <include file='_SectionName_e__FixedBuffer.xml' path='doc/member[@name="_SectionName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _SectionName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_InfFileName_e__FixedBuffer.xml' path='doc/member[@name="_InfFileName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _InfFileName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_DrvDescription_e__FixedBuffer.xml' path='doc/member[@name="_DrvDescription_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _DrvDescription_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_HardwareID_e__FixedBuffer.xml' path='doc/member[@name="_HardwareID_e__FixedBuffer"]/*' />
    public partial struct _HardwareID_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
