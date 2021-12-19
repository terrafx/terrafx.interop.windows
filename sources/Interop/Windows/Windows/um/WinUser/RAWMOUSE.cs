// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE"]/*' />
public partial struct RAWMOUSE
{
    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.usFlags"]/*' />
    public ushort usFlags;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.Anonymous"]/*' />
    [NativeTypeName("tagRAWMOUSE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/WinUser.h:14915:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.ulRawButtons"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulRawButtons;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.lLastX"]/*' />
    [NativeTypeName("LONG")]
    public int lLastX;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.lLastY"]/*' />
    [NativeTypeName("LONG")]
    public int lLastY;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.ulExtraInformation"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulExtraInformation;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulButtons"]/*' />
    public ref uint ulButtons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ulButtons, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonFlags"]/*' />
    public ref ushort usButtonFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.usButtonFlags, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonData"]/*' />
    public ref ushort usButtonData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.usButtonData, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulButtons"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ulButtons;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("tagRAWMOUSE::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/WinUser.h:14917:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonFlags"]/*' />
            public ushort usButtonFlags;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonData"]/*' />
            public ushort usButtonData;
        }
    }
}
