// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/activationregistration.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C8AA04F6-66C6-46A3-8FE6-F56BE7DDC091")]
    [NativeTypeName("struct IDllServerActivatableClassRegistration : IInspectable")]
    public unsafe partial struct IDllServerActivatableClassRegistration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDllServerActivatableClassRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IDllServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDllServerActivatableClassRegistration*, uint>)(lpVtbl[1]))((IDllServerActivatableClassRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDllServerActivatableClassRegistration*, uint>)(lpVtbl[2]))((IDllServerActivatableClassRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDllServerActivatableClassRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((IDllServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDllServerActivatableClassRegistration*, IntPtr*, int>)(lpVtbl[4]))((IDllServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDllServerActivatableClassRegistration*, TrustLevel*, int>)(lpVtbl[5]))((IDllServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DllPath([NativeTypeName("HSTRING *")] IntPtr* dllPath)
        {
            return ((delegate* unmanaged<IDllServerActivatableClassRegistration*, IntPtr*, int>)(lpVtbl[6]))((IDllServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), dllPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ThreadingType([NativeTypeName("ABI::Windows::Foundation::ThreadingType *")] ThreadingType* threadingType)
        {
            return ((delegate* unmanaged<IDllServerActivatableClassRegistration*, ThreadingType*, int>)(lpVtbl[7]))((IDllServerActivatableClassRegistration*)Unsafe.AsPointer(ref this), threadingType);
        }
    }
}
