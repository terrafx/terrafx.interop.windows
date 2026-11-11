// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='tagSYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_PARAMS"]/*' />
public partial struct tagSYNTHETIC_DEVICE_CREATION_PARAMS
{
    /// <include file='tagSYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_PARAMS.pointerType"]/*' />
    [NativeTypeName("POINTER_INPUT_TYPE")]
    public uint pointerType;

    /// <include file='tagSYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_PARAMS.maxCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint maxCount;

    /// <include file='tagSYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_PARAMS.feedbackMode"]/*' />
    public POINTER_FEEDBACK_MODE feedbackMode;

    /// <include file='tagSYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_PARAMS.hMonitor"]/*' />
    public HMONITOR hMonitor;

    /// <include file='tagSYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_PARAMS.deviceWidth"]/*' />
    [NativeTypeName("ULONG")]
    public uint deviceWidth;

    /// <include file='tagSYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_PARAMS.deviceHeight"]/*' />
    [NativeTypeName("ULONG")]
    public uint deviceHeight;

    /// <include file='tagSYNTHETIC_DEVICE_CREATION_PARAMS.xml' path='doc/member[@name="tagSYNTHETIC_DEVICE_CREATION_PARAMS.options"]/*' />
    [NativeTypeName("SYNTHETIC_DEVICE_CREATION_OPTIONS")]
    public tagSYNTHETIC_DEVICE_CREATION_OPTIONS options;
}
