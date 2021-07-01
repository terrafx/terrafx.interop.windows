// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.RO_INIT_TYPE;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoInitialize(RO_INIT_TYPE initType);

        [DllImport("combase", ExactSpelling = true)]
        public static extern void RoUninitialize();

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoActivateInstance([NativeTypeName("HSTRING")] IntPtr activatableClassId, IInspectable** instance);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoRegisterActivationFactories([NativeTypeName("HSTRING *")] IntPtr* activatableClassIds, [NativeTypeName("PFNGETACTIVATIONFACTORY *")] delegate* unmanaged<IntPtr, IActivationFactory**, int>* activationFactoryCallbacks, [NativeTypeName("UINT32")] uint count, [NativeTypeName("RO_REGISTRATION_COOKIE *")] IntPtr* cookie);

        [DllImport("combase", ExactSpelling = true)]
        public static extern void RoRevokeActivationFactories([NativeTypeName("RO_REGISTRATION_COOKIE")] IntPtr cookie);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetActivationFactory([NativeTypeName("HSTRING")] IntPtr activatableClassId, [NativeTypeName("const IID &")] Guid* iid, void** factory);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoRegisterForApartmentShutdown(IApartmentShutdown* callbackObject, [NativeTypeName("UINT64 *")] ulong* apartmentIdentifier, [NativeTypeName("APARTMENT_SHUTDOWN_REGISTRATION_COOKIE *")] IntPtr* regCookie);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoUnregisterForApartmentShutdown([NativeTypeName("APARTMENT_SHUTDOWN_REGISTRATION_COOKIE")] IntPtr regCookie);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetApartmentIdentifier([NativeTypeName("UINT64 *")] ulong* apartmentIdentifier);

        [return: NativeTypeName("HRESULT")]
        public static int Initialize(RO_INIT_TYPE initType = RO_INIT_SINGLETHREADED)
        {
            return RoInitialize(initType);
        }

        public static void Uninitialize()
        {
            RoUninitialize();
        }

        [return: NativeTypeName("HRESULT")]
        public static int RegisterActivationFactories([NativeTypeName("HSTRING *")] IntPtr* activatableClassIds, [NativeTypeName("PFNGETACTIVATIONFACTORY *")] delegate* unmanaged<IntPtr, IActivationFactory**, int>* activationFactoryCallbacks, [NativeTypeName("UINT32")] uint count, [NativeTypeName("RO_REGISTRATION_COOKIE *")] IntPtr* cookie)
        {
            return RoRegisterActivationFactories(activatableClassIds, activationFactoryCallbacks, count, cookie);
        }

        public static void RevokeActivationFactories([NativeTypeName("RO_REGISTRATION_COOKIE")] IntPtr cookie)
        {
            RoRevokeActivationFactories(cookie);
        }
    }
}
