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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIDebug1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIDebug1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIDebug1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReportLiveObjects(IDXGIDebug1* pThis, [NativeTypeName("GUID")] Guid apiid, DXGI_DEBUG_RLO_FLAGS flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _EnableLeakTrackingForThread(IDXGIDebug1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DisableLeakTrackingForThread(IDXGIDebug1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsLeakTrackingEnabledForThread(IDXGIDebug1* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIDebug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveObjects([NativeTypeName("GUID")] Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReportLiveObjects>(lpVtbl->ReportLiveObjects)((IDXGIDebug1*)Unsafe.AsPointer(ref this), apiid, flags);
        }

        public void EnableLeakTrackingForThread()
        {
            Marshal.GetDelegateForFunctionPointer<_EnableLeakTrackingForThread>(lpVtbl->EnableLeakTrackingForThread)((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        public void DisableLeakTrackingForThread()
        {
            Marshal.GetDelegateForFunctionPointer<_DisableLeakTrackingForThread>(lpVtbl->DisableLeakTrackingForThread)((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsLeakTrackingEnabledForThread()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsLeakTrackingEnabledForThread>(lpVtbl->IsLeakTrackingEnabledForThread)((IDXGIDebug1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (GUID, DXGI_DEBUG_RLO_FLAGS) __attribute__((stdcall))")]
            public IntPtr ReportLiveObjects;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr EnableLeakTrackingForThread;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr DisableLeakTrackingForThread;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr IsLeakTrackingEnabledForThread;
        }
    }
}
