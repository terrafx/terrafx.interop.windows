// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.WinRT.RO_INIT_TYPE;

namespace TerraFX.Interop.WinRT;

public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoInitialize"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoInitialize(RO_INIT_TYPE initType);

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoUninitialize"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void RoUninitialize();

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoActivateInstance"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoActivateInstance(HSTRING activatableClassId, IInspectable** instance);

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoRegisterActivationFactories"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoRegisterActivationFactories(HSTRING* activatableClassIds, [NativeTypeName("PFNGETACTIVATIONFACTORY *")] delegate* unmanaged<HSTRING, IActivationFactory**, HRESULT>* activationFactoryCallbacks, [NativeTypeName("UINT32")] uint count, RO_REGISTRATION_COOKIE* cookie);

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoRevokeActivationFactories"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void RoRevokeActivationFactories(RO_REGISTRATION_COOKIE cookie);

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoGetActivationFactory"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoGetActivationFactory(HSTRING activatableClassId, [NativeTypeName("const IID &")] Guid* iid, void** factory);

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoRegisterForApartmentShutdown"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoRegisterForApartmentShutdown(IApartmentShutdown* callbackObject, [NativeTypeName("UINT64 *")] ulong* apartmentIdentifier, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE* regCookie);

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoUnregisterForApartmentShutdown"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoUnregisterForApartmentShutdown(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE regCookie);

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoGetApartmentIdentifier"]/*' />
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoGetApartmentIdentifier([NativeTypeName("UINT64 *")] ulong* apartmentIdentifier);

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.Initialize"]/*' />
    [SupportedOSPlatform("windows6.2")]
    public static HRESULT Initialize(RO_INIT_TYPE initType = RO_INIT_SINGLETHREADED)
    {
        return RoInitialize(initType);
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.Uninitialize"]/*' />
    [SupportedOSPlatform("windows6.2")]
    public static void Uninitialize()
    {
        RoUninitialize();
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RegisterActivationFactories"]/*' />
    [SupportedOSPlatform("windows6.2")]
    public static HRESULT RegisterActivationFactories(HSTRING* activatableClassIds, [NativeTypeName("PFNGETACTIVATIONFACTORY *")] delegate* unmanaged<HSTRING, IActivationFactory**, HRESULT>* activationFactoryCallbacks, [NativeTypeName("UINT32")] uint count, RO_REGISTRATION_COOKIE* cookie)
    {
        return RoRegisterActivationFactories(activatableClassIds, activationFactoryCallbacks, count, cookie);
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RevokeActivationFactories"]/*' />
    [SupportedOSPlatform("windows6.2")]
    public static void RevokeActivationFactories(RO_REGISTRATION_COOKIE cookie)
    {
        RoRevokeActivationFactories(cookie);
    }
}
