// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [Guid("7A5B6FD1-CD73-4B6C-9CF4-2E869EAF470A")]
    [NativeTypeName("struct ICoreWindowAdapterInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct ICoreWindowAdapterInterop : ICoreWindowAdapterInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, uint>)(lpVtbl[1]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, uint>)(lpVtbl[2]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, HSTRING*, int>)(lpVtbl[4]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_AppActivationClientAdapter(IUnknown** value)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[6]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_ApplicationViewClientAdapter(IUnknown** value)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[7]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_CoreApplicationViewClientAdapter(IUnknown** value)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[8]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_HoloViewClientAdapter(IUnknown** value)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[9]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_SystemNavigationClientAdapter(IUnknown** value)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[10]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_TitleBarClientAdapter(IUnknown** value)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[11]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetWindowClientAdapter(IUnknown* value)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown*, int>)(lpVtbl[12]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        public interface Interface : IInspectable.Interface
        {
            [VtblIndex(6)]
            HRESULT get_AppActivationClientAdapter(IUnknown** value);

            [VtblIndex(7)]
            HRESULT get_ApplicationViewClientAdapter(IUnknown** value);

            [VtblIndex(8)]
            HRESULT get_CoreApplicationViewClientAdapter(IUnknown** value);

            [VtblIndex(9)]
            HRESULT get_HoloViewClientAdapter(IUnknown** value);

            [VtblIndex(10)]
            HRESULT get_SystemNavigationClientAdapter(IUnknown** value);

            [VtblIndex(11)]
            HRESULT get_TitleBarClientAdapter(IUnknown** value);

            [VtblIndex(12)]
            HRESULT SetWindowClientAdapter(IUnknown* value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> get_AppActivationClientAdapter;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> get_ApplicationViewClientAdapter;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> get_CoreApplicationViewClientAdapter;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> get_HoloViewClientAdapter;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> get_SystemNavigationClientAdapter;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown**, int> get_TitleBarClientAdapter;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreWindowAdapterInterop*, IUnknown*, int> SetWindowClientAdapter;
        }
    }
}
