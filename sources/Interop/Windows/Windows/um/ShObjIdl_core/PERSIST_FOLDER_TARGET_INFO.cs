// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PERSIST_FOLDER_TARGET_INFO.xml' path='doc/member[@name="PERSIST_FOLDER_TARGET_INFO"]/*' />
public unsafe partial struct PERSIST_FOLDER_TARGET_INFO
{
    /// <include file='PERSIST_FOLDER_TARGET_INFO.xml' path='doc/member[@name="PERSIST_FOLDER_TARGET_INFO.pidlTargetFolder"]/*' />
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidlTargetFolder;

    /// <include file='PERSIST_FOLDER_TARGET_INFO.xml' path='doc/member[@name="PERSIST_FOLDER_TARGET_INFO.szTargetParsingName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szTargetParsingName_e__FixedBuffer szTargetParsingName;

    /// <include file='PERSIST_FOLDER_TARGET_INFO.xml' path='doc/member[@name="PERSIST_FOLDER_TARGET_INFO.szNetworkProvider"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szNetworkProvider_e__FixedBuffer szNetworkProvider;

    /// <include file='PERSIST_FOLDER_TARGET_INFO.xml' path='doc/member[@name="PERSIST_FOLDER_TARGET_INFO.dwAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAttributes;

    /// <include file='PERSIST_FOLDER_TARGET_INFO.xml' path='doc/member[@name="PERSIST_FOLDER_TARGET_INFO.csidl"]/*' />
    public int csidl;

    /// <include file='_szTargetParsingName_e__FixedBuffer.xml' path='doc/member[@name="_szTargetParsingName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szTargetParsingName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szNetworkProvider_e__FixedBuffer.xml' path='doc/member[@name="_szNetworkProvider_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szNetworkProvider_e__FixedBuffer
    {
        public char e0;
    }
}
