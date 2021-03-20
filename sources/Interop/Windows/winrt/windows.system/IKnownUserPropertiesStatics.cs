// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7755911A-70C5-48E5-B637-5BA3441E4EE4")]
    [NativeTypeName("struct IKnownUserPropertiesStatics : IInspectable")]
    public unsafe partial struct IKnownUserPropertiesStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, uint>)(lpVtbl[1]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, uint>)(lpVtbl[2]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[4]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[6]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FirstName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[7]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[8]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ProviderName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[9]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AccountName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[10]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_GuestHost([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[11]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PrincipalName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[12]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DomainName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[13]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SessionInitiationProtocolUri([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IKnownUserPropertiesStatics*, IntPtr*, int>)(lpVtbl[14]))((IKnownUserPropertiesStatics*)Unsafe.AsPointer(ref this), value);
        }
    }
}
