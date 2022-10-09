// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS.xml' path='doc/member[@name="PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS
{
    /// <include file='PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS.xml' path='doc/member[@name="PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS.CommandType"]/*' />
    public PRJ_COMPLETE_COMMAND_TYPE CommandType;

    /// <include file='PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS.xml' path='doc/member[@name="PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS.Anonymous"]/*' />
    [NativeTypeName("PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:460:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Notification"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._Notification_e__Struct Notification
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Notification;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Enumeration"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._Enumeration_e__Struct Enumeration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Enumeration;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Notification"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:461:9)")]
        public _Notification_e__Struct Notification;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Enumeration"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:465:9)")]
        public _Enumeration_e__Struct Enumeration;

        /// <include file='_Notification_e__Struct.xml' path='doc/member[@name="_Notification_e__Struct"]/*' />
        public partial struct _Notification_e__Struct
        {
            /// <include file='_Notification_e__Struct.xml' path='doc/member[@name="_Notification_e__Struct.NotificationMask"]/*' />
            public PRJ_NOTIFY_TYPES NotificationMask;
        }

        /// <include file='_Enumeration_e__Struct.xml' path='doc/member[@name="_Enumeration_e__Struct"]/*' />
        public partial struct _Enumeration_e__Struct
        {
            /// <include file='_Enumeration_e__Struct.xml' path='doc/member[@name="_Enumeration_e__Struct.DirEntryBufferHandle"]/*' />
            public PRJ_DIR_ENTRY_BUFFER_HANDLE DirEntryBufferHandle;
        }
    }
}
