// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS
    {
        public PRJ_COMPLETE_COMMAND_TYPE CommandType;

        [NativeTypeName("PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/projectedfslib.h:460:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._Notification_e__Struct Notification
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Notification, 1));
            }
        }

        public ref _Anonymous_e__Union._Enumeration_e__Struct Enumeration
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Enumeration, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/projectedfslib.h:461:9)")]
            public _Notification_e__Struct Notification;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/projectedfslib.h:465:9)")]
            public _Enumeration_e__Struct Enumeration;

            public partial struct _Notification_e__Struct
            {
                public PRJ_NOTIFY_TYPES NotificationMask;
            }

            public partial struct _Enumeration_e__Struct
            {
                [NativeTypeName("PRJ_DIR_ENTRY_BUFFER_HANDLE")]
                public IntPtr DirEntryBufferHandle;
            }
        }
    }
}
