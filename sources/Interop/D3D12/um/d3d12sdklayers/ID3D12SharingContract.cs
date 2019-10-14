// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0ADF7D52-929C-4E61-ADDB-FFED30DE66EF")]
    public unsafe partial struct ID3D12SharingContract
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12SharingContract* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12SharingContract* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12SharingContract* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Present(ID3D12SharingContract* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("HWND")] IntPtr window);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SharedFenceSignal(ID3D12SharingContract* pThis, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginCapturableWork(ID3D12SharingContract* pThis, [NativeTypeName("const GUID &")] Guid* guid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndCapturableWork(ID3D12SharingContract* pThis, [NativeTypeName("const GUID &")] Guid* guid);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12SharingContract*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
        }

        public void Present([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("HWND")] IntPtr window)
        {
            Marshal.GetDelegateForFunctionPointer<_Present>(lpVtbl->Present)((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pResource, Subresource, window);
        }

        public void SharedFenceSignal([NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue)
        {
            Marshal.GetDelegateForFunctionPointer<_SharedFenceSignal>(lpVtbl->SharedFenceSignal)((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pFence, FenceValue);
        }

        public void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            Marshal.GetDelegateForFunctionPointer<_BeginCapturableWork>(lpVtbl->BeginCapturableWork)((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
        }

        public void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            Marshal.GetDelegateForFunctionPointer<_EndCapturableWork>(lpVtbl->EndCapturableWork)((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID3D12Resource *, UINT, HWND) __attribute__((stdcall))")]
            public IntPtr Present;

            [NativeTypeName("void (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public IntPtr SharedFenceSignal;

            [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
            public IntPtr BeginCapturableWork;

            [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
            public IntPtr EndCapturableWork;
        }
    }
}
