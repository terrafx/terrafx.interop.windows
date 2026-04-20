// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TOUCHPAD_PARAMETERS_V2.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V2"]/*' />
[NativeTypeName("struct tagTOUCHPAD_PARAMETERS_V2 : TOUCHPAD_PARAMETERS_V1")]
[NativeInheritance("TOUCHPAD_PARAMETERS_V1")]
public partial struct TOUCHPAD_PARAMETERS_V2
{
    public TOUCHPAD_PARAMETERS_V1 Base;

    public BOOL _bitfield;

    /// <include file='TOUCHPAD_PARAMETERS_V2.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V2.button1Supported"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL button1Supported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield << 31) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1) | (value & 0x1);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V2.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V2.button2Supported"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL button2Supported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield << 30) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 1)) | ((value & 0x1) << 1);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V2.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V2.button3Supported"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL button3Supported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield << 29) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 2)) | ((value & 0x1) << 2);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V2.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V2.Reserved3"]/*' />
    [NativeTypeName("BOOL : 29")]
    public BOOL Reserved3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield << 0) >> 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1FFFFFFF << 3)) | ((value & 0x1FFFFFFF) << 3);
        }
    }
}
