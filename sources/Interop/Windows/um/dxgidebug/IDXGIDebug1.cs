// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
    [NativeTypeName("struct IDXGIDebug1 : IDXGIDebug")]
    [NativeInheritance("IDXGIDebug")]
    public unsafe partial struct IDXGIDebug1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIDebug1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDebug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIDebug1*, uint>)(lpVtbl[1]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIDebug1*, uint>)(lpVtbl[2]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
        {
            return ((delegate* unmanaged<IDXGIDebug1*, Guid, DXGI_DEBUG_RLO_FLAGS, int>)(lpVtbl[3]))((IDXGIDebug1*)Unsafe.AsPointer(ref this), apiid, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void EnableLeakTrackingForThread()
        {
            ((delegate* unmanaged<IDXGIDebug1*, void>)(lpVtbl[4]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void DisableLeakTrackingForThread()
        {
            ((delegate* unmanaged<IDXGIDebug1*, void>)(lpVtbl[5]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public BOOL IsLeakTrackingEnabledForThread()
        {
            return ((delegate* unmanaged<IDXGIDebug1*, int>)(lpVtbl[6]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIDebug1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIDebug1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIDebug1*, uint> Release;

            [NativeTypeName("HRESULT (GUID, DXGI_DEBUG_RLO_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIDebug1*, Guid, DXGI_DEBUG_RLO_FLAGS, int> ReportLiveObjects;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIDebug1*, void> EnableLeakTrackingForThread;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIDebug1*, void> DisableLeakTrackingForThread;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IDXGIDebug1*, int> IsLeakTrackingEnabledForThread;
        }
    }
}
