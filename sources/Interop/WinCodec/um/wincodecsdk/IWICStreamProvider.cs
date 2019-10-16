// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICStreamProvider
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICStreamProvider* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICStreamProvider* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICStreamProvider* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStream(IWICStreamProvider* pThis, [NativeTypeName("IStream **")] IStream** ppIStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPersistOptions(IWICStreamProvider* pThis, [NativeTypeName("DWORD *")] uint* pdwPersistOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPreferredVendorGUID(IWICStreamProvider* pThis, [NativeTypeName("GUID *")] Guid* pguidPreferredVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RefreshStream(IWICStreamProvider* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICStreamProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStream([NativeTypeName("IStream **")] IStream** ppIStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStream>(lpVtbl->GetStream)((IWICStreamProvider*)Unsafe.AsPointer(ref this), ppIStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPersistOptions>(lpVtbl->GetPersistOptions)((IWICStreamProvider*)Unsafe.AsPointer(ref this), pdwPersistOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreferredVendorGUID([NativeTypeName("GUID *")] Guid* pguidPreferredVendor)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPreferredVendorGUID>(lpVtbl->GetPreferredVendorGUID)((IWICStreamProvider*)Unsafe.AsPointer(ref this), pguidPreferredVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int RefreshStream()
        {
            return Marshal.GetDelegateForFunctionPointer<_RefreshStream>(lpVtbl->RefreshStream)((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public IntPtr GetStream;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetPersistOptions;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetPreferredVendorGUID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr RefreshStream;
        }
    }
}
