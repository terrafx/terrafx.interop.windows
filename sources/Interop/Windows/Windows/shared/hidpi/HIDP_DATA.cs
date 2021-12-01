// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='HIDP_DATA.xml' path='doc/member[@name="HIDP_DATA"]/*' />
public partial struct HIDP_DATA
{
    /// <include file='HIDP_DATA.xml' path='doc/member[@name="HIDP_DATA.DataIndex"]/*' />
    public ushort DataIndex;

    /// <include file='HIDP_DATA.xml' path='doc/member[@name="HIDP_DATA.Reserved"]/*' />
    public ushort Reserved;

    /// <include file='HIDP_DATA.xml' path='doc/member[@name="HIDP_DATA.Anonymous"]/*' />
    [NativeTypeName("_HIDP_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/hidpi.h:269:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RawValue"]/*' />
    public ref uint RawValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.RawValue, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.On"]/*' />
    public ref byte On
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.On, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RawValue"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint RawValue;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.On"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BOOLEAN")]
        public byte On;
    }
}
