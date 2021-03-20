// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roregistrationapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetActivatableClassRegistration([NativeTypeName("HSTRING")] IntPtr activatableClassId, [NativeTypeName("PActivatableClassRegistration *")] IActivatableClassRegistration** activatableClassRegistration);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetServerActivatableClasses([NativeTypeName("HSTRING")] IntPtr serverName, [NativeTypeName("HSTRING **")] IntPtr** activatableClassIds, [NativeTypeName("DWORD *")] uint* count);

        [return: NativeTypeName("HRESULT")]
        public static int GetActivatableClassRegistration([NativeTypeName("HSTRING")] IntPtr activatableClassId, [NativeTypeName("PActivatableClassRegistration *")] IActivatableClassRegistration** activatableClassRegistration)
        {
            return RoGetActivatableClassRegistration(activatableClassId, activatableClassRegistration);
        }

        [return: NativeTypeName("HRESULT")]
        public static int GetServerActivatableClasses([NativeTypeName("HSTRING")] IntPtr serverName, [NativeTypeName("HSTRING **")] IntPtr** activatableClassIds, [NativeTypeName("DWORD *")] uint* count)
        {
            return RoGetServerActivatableClasses(serverName, activatableClassIds, count);
        }
    }
}
