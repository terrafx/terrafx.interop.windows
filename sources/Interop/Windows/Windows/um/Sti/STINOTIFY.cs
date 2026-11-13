// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STINOTIFY.xml' path='doc/member[@name="STINOTIFY"]/*' />
public partial struct STINOTIFY
{
    /// <include file='STINOTIFY.xml' path='doc/member[@name="STINOTIFY.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='STINOTIFY.xml' path='doc/member[@name="STINOTIFY.guidNotificationCode"]/*' />
    public Guid guidNotificationCode;

    /// <include file='STINOTIFY.xml' path='doc/member[@name="STINOTIFY.abNotificationData"]/*' />
    [NativeTypeName("BYTE[64]")]
    public _abNotificationData_e__FixedBuffer abNotificationData;

    /// <include file='_abNotificationData_e__FixedBuffer.xml' path='doc/member[@name="_abNotificationData_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _abNotificationData_e__FixedBuffer
    {
        public byte e0;
    }
}
