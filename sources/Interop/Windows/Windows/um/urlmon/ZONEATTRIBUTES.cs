// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES"]/*' />
public partial struct ZONEATTRIBUTES
{
    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.szDisplayName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szDisplayName_e__FixedBuffer szDisplayName;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.szDescription"]/*' />
    [NativeTypeName("WCHAR[200]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.szIconPath"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szIconPath_e__FixedBuffer szIconPath;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.dwTemplateMinLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTemplateMinLevel;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.dwTemplateRecommended"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTemplateRecommended;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.dwTemplateCurrentLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTemplateCurrentLevel;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='_szDisplayName_e__FixedBuffer.xml' path='doc/member[@name="_szDisplayName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDisplayName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [InlineArray(200)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDescription_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szIconPath_e__FixedBuffer.xml' path='doc/member[@name="_szIconPath_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szIconPath_e__FixedBuffer
    {
        public char e0;
    }
}
