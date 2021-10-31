// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A5B6FD1-CD73-4B6C-9CF4-2E869EAF470A")]
    [NativeTypeName("struct ICoreWindowAdapterInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct ICoreWindowAdapterInterop
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
        public HRESULT GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindowAdapterInterop*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), className);
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
    }
}
