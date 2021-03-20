// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/activationregistration.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9308C3C5-C2AC-49D1-A024-660A2BB5D5AC")]
    [NativeTypeName("struct IExeServerActivatableClassRegistration : IInspectable")]
    public unsafe partial struct IExeServerActivatableClassRegistration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IExeServerActivatableClassRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IExeServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExeServerActivatableClassRegistration*, uint>)(lpVtbl[1]))((IExeServerActivatableClassRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExeServerActivatableClassRegistration*, uint>)(lpVtbl[2]))((IExeServerActivatableClassRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IExeServerActivatableClassRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((IExeServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IExeServerActivatableClassRegistration*, IntPtr*, int>)(lpVtbl[4]))((IExeServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IExeServerActivatableClassRegistration*, TrustLevel*, int>)(lpVtbl[5]))((IExeServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ServerRegistration([NativeTypeName("ABI::Windows::Foundation::IExeServerRegistration **")] IExeServerRegistration** serverRegistration)
        {
            return ((delegate* unmanaged<IExeServerActivatableClassRegistration*, IExeServerRegistration**, int>)(lpVtbl[6]))((IExeServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), serverRegistration);
        }
    }
}
