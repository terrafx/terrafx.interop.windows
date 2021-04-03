// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
    [NativeTypeName("struct IDXGIDebug1 : IDXGIDebug")]
    public unsafe partial struct IDXGIDebug1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIDebug1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDebug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIDebug1*, uint>)(lpVtbl[1]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIDebug1*, uint>)(lpVtbl[2]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReportLiveObjects([NativeTypeName("GUID")] Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
        {
            return ((delegate* unmanaged<IDXGIDebug1*, Guid, DXGI_DEBUG_RLO_FLAGS, int>)(lpVtbl[3]))((IDXGIDebug1*)Unsafe.AsPointer(ref this), apiid, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EnableLeakTrackingForThread()
        {
            ((delegate* unmanaged<IDXGIDebug1*, void>)(lpVtbl[4]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DisableLeakTrackingForThread()
        {
            ((delegate* unmanaged<IDXGIDebug1*, void>)(lpVtbl[5]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsLeakTrackingEnabledForThread()
        {
            return ((delegate* unmanaged<IDXGIDebug1*, int>)(lpVtbl[6]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }
    }
}
