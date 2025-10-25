// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1"]/*' />
public partial struct TOUCHPAD_PARAMETERS_V1
{
    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.versionNumber"]/*' />
    public uint versionNumber;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.maxSupportedContacts"]/*' />
    public uint maxSupportedContacts;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.legacyTouchpadFeatures"]/*' />
    public LEGACY_TOUCHPAD_FEATURES legacyTouchpadFeatures;

    public BOOL _bitfield1;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.touchpadPresent"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL touchpadPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 << 31) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~0x1) | (value & 0x1);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.legacyTouchpadPresent"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL legacyTouchpadPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 << 30) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 1)) | ((value & 0x1) << 1);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.externalMousePresent"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL externalMousePresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 << 29) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 2)) | ((value & 0x1) << 2);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.touchpadEnabled"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL touchpadEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 << 28) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 3)) | ((value & 0x1) << 3);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.touchpadActive"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL touchpadActive
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 << 27) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 4)) | ((value & 0x1) << 4);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.feedbackSupported"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL feedbackSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 << 26) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 5)) | ((value & 0x1) << 5);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.clickForceSupported"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL clickForceSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 << 25) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 6)) | ((value & 0x1) << 6);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.Reserved1"]/*' />
    [NativeTypeName("BOOL : 25")]
    public BOOL Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 << 0) >> 7;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1FFFFFF << 7)) | ((value & 0x1FFFFFF) << 7);
        }
    }

    public BOOL _bitfield2;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.allowActiveWhenMousePresent"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL allowActiveWhenMousePresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 31) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~0x1) | (value & 0x1);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.feedbackEnabled"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL feedbackEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 30) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 1)) | ((value & 0x1) << 1);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.tapEnabled"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL tapEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 29) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 2)) | ((value & 0x1) << 2);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.tapAndDragEnabled"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL tapAndDragEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 28) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 3)) | ((value & 0x1) << 3);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.twoFingerTapEnabled"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL twoFingerTapEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 27) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 4)) | ((value & 0x1) << 4);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.rightClickZoneEnabled"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL rightClickZoneEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 26) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 5)) | ((value & 0x1) << 5);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.mouseAccelSettingHonored"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL mouseAccelSettingHonored
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 25) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 6)) | ((value & 0x1) << 6);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.panEnabled"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL panEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 24) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 7)) | ((value & 0x1) << 7);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.zoomEnabled"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL zoomEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 23) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 8)) | ((value & 0x1) << 8);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.scrollDirectionReversed"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL scrollDirectionReversed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 22) >> 31;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 9)) | ((value & 0x1) << 9);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.Reserved2"]/*' />
    [NativeTypeName("BOOL : 22")]
    public BOOL Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield2 << 0) >> 10;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x3FFFFF << 10)) | ((value & 0x3FFFFF) << 10);
        }
    }

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.sensitivityLevel"]/*' />
    public TOUCHPAD_SENSITIVITY_LEVEL sensitivityLevel;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.cursorSpeed"]/*' />
    public uint cursorSpeed;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.feedbackIntensity"]/*' />
    public uint feedbackIntensity;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.clickForceSensitivity"]/*' />
    public uint clickForceSensitivity;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.rightClickZoneWidth"]/*' />
    public uint rightClickZoneWidth;

    /// <include file='TOUCHPAD_PARAMETERS_V1.xml' path='doc/member[@name="TOUCHPAD_PARAMETERS_V1.rightClickZoneHeight"]/*' />
    public uint rightClickZoneHeight;
}
