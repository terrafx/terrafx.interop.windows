// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.WinRT.RO_INIT_TYPE;

namespace TerraFX.Interop.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoInitialize(RO_INIT_TYPE initType);

    [DllImport("combase", ExactSpelling = true)]
    public static extern void RoUninitialize();

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoActivateInstance(HSTRING activatableClassId, IInspectable** instance);

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoRegisterActivationFactories(HSTRING* activatableClassIds, [NativeTypeName("PFNGETACTIVATIONFACTORY *")] delegate* unmanaged<HSTRING, IActivationFactory**, HRESULT>* activationFactoryCallbacks, [NativeTypeName("UINT32")] uint count, RO_REGISTRATION_COOKIE* cookie);

    [DllImport("combase", ExactSpelling = true)]
    public static extern void RoRevokeActivationFactories(RO_REGISTRATION_COOKIE cookie);

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoGetActivationFactory(HSTRING activatableClassId, [NativeTypeName("const IID &")] Guid* iid, void** factory);

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoRegisterForApartmentShutdown(IApartmentShutdown* callbackObject, [NativeTypeName("UINT64 *")] ulong* apartmentIdentifier, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE* regCookie);

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoUnregisterForApartmentShutdown(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE regCookie);

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoGetApartmentIdentifier([NativeTypeName("UINT64 *")] ulong* apartmentIdentifier);

    public static HRESULT Initialize(RO_INIT_TYPE initType = RO_INIT_SINGLETHREADED)
    {
        return RoInitialize(initType);
    }

    public static void Uninitialize()
    {
        RoUninitialize();
    }

    public static HRESULT RegisterActivationFactories(HSTRING* activatableClassIds, [NativeTypeName("PFNGETACTIVATIONFACTORY *")] delegate* unmanaged<HSTRING, IActivationFactory**, HRESULT>* activationFactoryCallbacks, [NativeTypeName("UINT32")] uint count, RO_REGISTRATION_COOKIE* cookie)
    {
        return RoRegisterActivationFactories(activatableClassIds, activationFactoryCallbacks, count, cookie);
    }

    public static void RevokeActivationFactories(RO_REGISTRATION_COOKIE cookie)
    {
        RoRevokeActivationFactories(cookie);
    }
}
