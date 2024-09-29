// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_HEADER.xml' path='doc/member[@name="MINIDUMP_HEADER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_HEADER
{
    /// <include file='MINIDUMP_HEADER.xml' path='doc/member[@name="MINIDUMP_HEADER.Signature"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Signature;

    /// <include file='MINIDUMP_HEADER.xml' path='doc/member[@name="MINIDUMP_HEADER.Version"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Version;

    /// <include file='MINIDUMP_HEADER.xml' path='doc/member[@name="MINIDUMP_HEADER.NumberOfStreams"]/*' />
    [NativeTypeName("ULONG32")]
    public uint NumberOfStreams;

    /// <include file='MINIDUMP_HEADER.xml' path='doc/member[@name="MINIDUMP_HEADER.StreamDirectoryRva"]/*' />
    [NativeTypeName("RVA")]
    public uint StreamDirectoryRva;

    /// <include file='MINIDUMP_HEADER.xml' path='doc/member[@name="MINIDUMP_HEADER.CheckSum"]/*' />
    [NativeTypeName("ULONG32")]
    public uint CheckSum;

    /// <include file='MINIDUMP_HEADER.xml' path='doc/member[@name="MINIDUMP_HEADER.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_minidumpapiset_L82_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='MINIDUMP_HEADER.xml' path='doc/member[@name="MINIDUMP_HEADER.Flags"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Flags;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
    [UnscopedRef]
    public ref uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Reserved;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TimeDateStamp"]/*' />
    [UnscopedRef]
    public ref uint TimeDateStamp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TimeDateStamp;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG32")]
        public uint Reserved;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TimeDateStamp"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG32")]
        public uint TimeDateStamp;
    }
}
