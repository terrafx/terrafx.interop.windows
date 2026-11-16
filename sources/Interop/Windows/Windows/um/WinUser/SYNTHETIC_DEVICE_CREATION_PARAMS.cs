// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="SYNTHETIC_DEVICE_CREATION_PARAMS"]/*' />
public partial struct SYNTHETIC_DEVICE_CREATION_PARAMS
{
    /// <include file='SYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="SYNTHETIC_DEVICE_CREATION_PARAMS.pointerType"]/*' />
    [NativeTypeName("POINTER_INPUT_TYPE")]
    public uint pointerType;

    /// <include file='SYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="SYNTHETIC_DEVICE_CREATION_PARAMS.maxCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint maxCount;

    /// <include file='SYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="SYNTHETIC_DEVICE_CREATION_PARAMS.feedbackMode"]/*' />
    public POINTER_FEEDBACK_MODE feedbackMode;

    /// <include file='SYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="SYNTHETIC_DEVICE_CREATION_PARAMS.hMonitor"]/*' />
    public HMONITOR hMonitor;

    /// <include file='SYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="SYNTHETIC_DEVICE_CREATION_PARAMS.deviceWidth"]/*' />
    [NativeTypeName("ULONG")]
    public uint deviceWidth;

    /// <include file='SYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="SYNTHETIC_DEVICE_CREATION_PARAMS.deviceHeight"]/*' />
    [NativeTypeName("ULONG")]
    public uint deviceHeight;

    /// <include file='SYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="SYNTHETIC_DEVICE_CREATION_PARAMS.options"]/*' />
    public SYNTHETIC_DEVICE_CREATION_OPTIONS options;
}
