// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialInteractionManagerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.15063.0")]
    [Guid("5C4EE536-6A98-4B86-A170-587013D6FD4B")]
    [NativeTypeName("struct ISpatialInteractionManagerInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct ISpatialInteractionManagerInterop : ISpatialInteractionManagerInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, uint>)(lpVtbl[1]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, uint>)(lpVtbl[2]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, HSTRING*, int>)(lpVtbl[4]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetForWindow(HWND window, [NativeTypeName("const IID &")] Guid* riid, void** spatialInteractionManager)
        {
            return ((delegate* unmanaged<ISpatialInteractionManagerInterop*, HWND, Guid*, void**, int>)(lpVtbl[6]))((ISpatialInteractionManagerInterop*)Unsafe.AsPointer(ref this), window, riid, spatialInteractionManager);
        }

        public interface Interface : IInspectable.Interface
        {
            [VtblIndex(6)]
            HRESULT GetForWindow(HWND window, [NativeTypeName("const IID &")] Guid* riid, void** spatialInteractionManager);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialInteractionManagerInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialInteractionManagerInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialInteractionManagerInterop*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialInteractionManagerInterop*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialInteractionManagerInterop*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialInteractionManagerInterop*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialInteractionManagerInterop*, HWND, Guid*, void**, int> GetForWindow;
        }
    }
}
