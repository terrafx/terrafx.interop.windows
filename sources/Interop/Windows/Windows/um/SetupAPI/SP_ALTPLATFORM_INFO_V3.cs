// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3"]/*' />
public partial struct SP_ALTPLATFORM_INFO_V3
{
    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.Platform"]/*' />
    [NativeTypeName("DWORD")]
    public uint Platform;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.MajorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint MajorVersion;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.MinorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinorVersion;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.ProcessorArchitecture"]/*' />
    [NativeTypeName("WORD")]
    public ushort ProcessorArchitecture;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_SetupAPI_L164_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.FirstValidatedMajorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint FirstValidatedMajorVersion;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.FirstValidatedMinorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint FirstValidatedMinorVersion;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.ProductType"]/*' />
    public byte ProductType;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.SuiteMask"]/*' />
    [NativeTypeName("WORD")]
    public ushort SuiteMask;

    /// <include file='SP_ALTPLATFORM_INFO_V3.xml' path='doc/member[@name="SP_ALTPLATFORM_INFO_V3.BuildNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint BuildNumber;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
    [UnscopedRef]
    public ref ushort Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Reserved;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
    [UnscopedRef]
    public ref ushort Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Flags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Reserved;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Flags;
    }
}
