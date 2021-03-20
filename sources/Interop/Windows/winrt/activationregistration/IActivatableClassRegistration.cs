// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/activationregistration.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9BBCAE23-3DD6-49C3-B63C-1C587E7A6A67")]
    [NativeTypeName("struct IActivatableClassRegistration : IInspectable")]
    public unsafe partial struct IActivatableClassRegistration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, uint>)(lpVtbl[1]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, uint>)(lpVtbl[2]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, IntPtr*, int>)(lpVtbl[4]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, TrustLevel*, int>)(lpVtbl[5]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ActivatableClassId([NativeTypeName("HSTRING *")] IntPtr* activatableClassID)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, IntPtr*, int>)(lpVtbl[6]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), activatableClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ActivationType([NativeTypeName("ABI::Windows::Foundation::ActivationType *")] ActivationType* activationType)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, ActivationType*, int>)(lpVtbl[7]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), activationType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RegistrationScope([NativeTypeName("ABI::Windows::Foundation::RegistrationScope *")] RegistrationScope* registrationScope)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, RegistrationScope*, int>)(lpVtbl[8]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), registrationScope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RegisteredTrustLevel([NativeTypeName("ABI::Windows::Foundation::RegisteredTrustLevel *")] TrustLevel* registeredTrustLevel)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, TrustLevel*, int>)(lpVtbl[9]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), registeredTrustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Attributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_IInspectable_t **")] IMapView<IntPtr, IntPtr>** attributes)
        {
            return ((delegate* unmanaged<IActivatableClassRegistration*, IMapView<IntPtr, IntPtr>**, int>)(lpVtbl[10]))((IActivatableClassRegistration*)Unsafe.AsPointer(ref this), attributes);
        }
    }
}
