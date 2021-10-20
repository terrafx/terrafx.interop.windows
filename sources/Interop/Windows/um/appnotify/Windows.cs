// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appnotify.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("twinapi.appcore.dll", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint RegisterAppStateChangeNotification([NativeTypeName("PAPPSTATE_CHANGE_ROUTINE")] delegate* unmanaged<byte, void*, void> Routine, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PAPPSTATE_REGISTRATION *")] IntPtr* Registration);

        [DllImport("twinapi.appcore.dll", ExactSpelling = true)]
        public static extern void UnregisterAppStateChangeNotification([NativeTypeName("PAPPSTATE_REGISTRATION")] IntPtr Registration);

        [DllImport("twinapi.appcore.dll", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint RegisterAppConstrainedChangeNotification([NativeTypeName("PAPPCONSTRAIN_CHANGE_ROUTINE")] delegate* unmanaged<byte, void*, void> Routine, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PAPPCONSTRAIN_REGISTRATION *")] IntPtr* Registration);

        [DllImport("twinapi.appcore.dll", ExactSpelling = true)]
        public static extern void UnregisterAppConstrainedChangeNotification([NativeTypeName("PAPPCONSTRAIN_REGISTRATION")] IntPtr Registration);
    }
}
