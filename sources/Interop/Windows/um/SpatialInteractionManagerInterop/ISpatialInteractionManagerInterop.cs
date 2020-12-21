// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialInteractionManagerInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C4EE536-6A98-4B86-A170-587013D6FD4B")]
    [NativeTypeName("struct ISpatialInteractionManagerInterop : IInspectable")]
    public unsafe partial struct ISpatialInteractionManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, uint>)(lpVtbl[1]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, uint>)(lpVtbl[2]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, IntPtr*, int>)(lpVtbl[4]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForWindow([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** spatialInteractionManager)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), window, riid, spatialInteractionManager);
        }
    }
}
