// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dragdropinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [Guid("5AD8CBA7-4C01-4DAC-9074-827894292D63")]
    [NativeTypeName("struct IDragDropManagerInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IDragDropManagerInterop : IDragDropManagerInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDragDropManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDragDropManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDragDropManagerInterop*, uint>)(lpVtbl[1]))((IDragDropManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDragDropManagerInterop*, uint>)(lpVtbl[2]))((IDragDropManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDragDropManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IDragDropManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IDragDropManagerInterop*, HSTRING*, int>)(lpVtbl[4]))((IDragDropManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDragDropManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IDragDropManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetForWindow(HWND hwnd, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDragDropManagerInterop*, HWND, Guid*, void**, int>)(lpVtbl[6]))((IDragDropManagerInterop*)Unsafe.AsPointer(ref this), hwnd, riid, ppv);
        }

        public interface Interface : IInspectable.Interface
        {
            [VtblIndex(6)]
            HRESULT GetForWindow(HWND hwnd, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDragDropManagerInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDragDropManagerInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDragDropManagerInterop*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDragDropManagerInterop*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDragDropManagerInterop*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDragDropManagerInterop*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDragDropManagerInterop*, HWND, Guid*, void**, int> GetForWindow;
        }
    }
}
