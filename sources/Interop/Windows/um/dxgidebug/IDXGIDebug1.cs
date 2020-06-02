// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
    public unsafe partial struct IDXGIDebug1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIDebug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveObjects([NativeTypeName("GUID")] Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
        {
            return lpVtbl->ReportLiveObjects((IDXGIDebug1*)Unsafe.AsPointer(ref this), apiid, flags);
        }

        public void EnableLeakTrackingForThread()
        {
            lpVtbl->EnableLeakTrackingForThread((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        public void DisableLeakTrackingForThread()
        {
            lpVtbl->DisableLeakTrackingForThread((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsLeakTrackingEnabledForThread()
        {
            return lpVtbl->IsLeakTrackingEnabledForThread((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug1*, uint> Release;

            [NativeTypeName("HRESULT (GUID, DXGI_DEBUG_RLO_FLAGS) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug1*, Guid, DXGI_DEBUG_RLO_FLAGS, int> ReportLiveObjects;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug1*, void> EnableLeakTrackingForThread;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug1*, void> DisableLeakTrackingForThread;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug1*, int> IsLeakTrackingEnabledForThread;
        }
    }
}
