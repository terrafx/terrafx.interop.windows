// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oobenotification.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL RegisterWaitUntilOOBECompleted([NativeTypeName("OOBE_COMPLETED_CALLBACK")] delegate* unmanaged<void*, void> OOBECompletedCallback, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PVOID *")] void** WaitHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL UnregisterWaitUntilOOBECompleted([NativeTypeName("PVOID")] void* WaitHandle);
    }
}
