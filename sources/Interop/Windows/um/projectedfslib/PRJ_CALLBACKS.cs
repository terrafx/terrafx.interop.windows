// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_CALLBACKS
    {
        [NativeTypeName("PRJ_START_DIRECTORY_ENUMERATION_CB *")]
        public delegate* unmanaged<PRJ_CALLBACK_DATA*, Guid*, int> StartDirectoryEnumerationCallback;

        [NativeTypeName("PRJ_END_DIRECTORY_ENUMERATION_CB *")]
        public delegate* unmanaged<PRJ_CALLBACK_DATA*, Guid*, int> EndDirectoryEnumerationCallback;

        [NativeTypeName("PRJ_GET_DIRECTORY_ENUMERATION_CB *")]
        public delegate* unmanaged<PRJ_CALLBACK_DATA*, Guid*, ushort*, IntPtr, int> GetDirectoryEnumerationCallback;

        [NativeTypeName("PRJ_GET_PLACEHOLDER_INFO_CB *")]
        public delegate* unmanaged<PRJ_CALLBACK_DATA*, int> GetPlaceholderInfoCallback;

        [NativeTypeName("PRJ_GET_FILE_DATA_CB *")]
        public delegate* unmanaged<PRJ_CALLBACK_DATA*, ulong, uint, int> GetFileDataCallback;

        [NativeTypeName("PRJ_QUERY_FILE_NAME_CB *")]
        public delegate* unmanaged<PRJ_CALLBACK_DATA*, int> QueryFileNameCallback;

        [NativeTypeName("PRJ_NOTIFICATION_CB *")]
        public delegate* unmanaged<PRJ_CALLBACK_DATA*, byte, PRJ_NOTIFICATION, ushort*, PRJ_NOTIFICATION_PARAMETERS*, int> NotificationCallback;

        [NativeTypeName("PRJ_CANCEL_COMMAND_CB *")]
        public delegate* unmanaged<PRJ_CALLBACK_DATA*, void> CancelCommandCallback;
    }
}
