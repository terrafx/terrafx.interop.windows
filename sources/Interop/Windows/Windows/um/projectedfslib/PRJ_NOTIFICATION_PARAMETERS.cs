// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_NOTIFICATION_PARAMETERS
{
    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:407:5)")]
    public _PostCreate_e__Struct PostCreate;

    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:411:5)")]
    public _FileRenamed_e__Struct FileRenamed;

    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:415:5)")]
    public _FileDeletedOnHandleClose_e__Struct FileDeletedOnHandleClose;

    public partial struct _PostCreate_e__Struct
    {
        public PRJ_NOTIFY_TYPES NotificationMask;
    }

    public partial struct _FileRenamed_e__Struct
    {
        public PRJ_NOTIFY_TYPES NotificationMask;
    }

    public partial struct _FileDeletedOnHandleClose_e__Struct
    {
        [NativeTypeName("BOOLEAN")]
        public byte IsFileModified;
    }
}
