// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("449494BC-B468-4927-96D7-BA90D31AB505")]
    public unsafe partial struct IWICStreamProvider
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICStreamProvider* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICStreamProvider* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICStreamProvider* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStream(IWICStreamProvider* This, IStream** ppIStream = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPersistOptions(IWICStreamProvider* This, [NativeTypeName("DWORD")] uint* pdwPersistOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPreferredVendorGUID(IWICStreamProvider* This, [NativeTypeName("GUID")] Guid* pguidPreferredVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RefreshStream(IWICStreamProvider* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStream(IStream** ppIStream = null)
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStream>(lpVtbl->GetStream)(This, ppIStream);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPersistOptions([NativeTypeName("DWORD")] uint* pdwPersistOptions)
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPersistOptions>(lpVtbl->GetPersistOptions)(This, pdwPersistOptions);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreferredVendorGUID([NativeTypeName("GUID")] Guid* pguidPreferredVendor)
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPreferredVendorGUID>(lpVtbl->GetPreferredVendorGUID)(This, pguidPreferredVendor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RefreshStream()
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RefreshStream>(lpVtbl->RefreshStream)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetStream;

            public IntPtr GetPersistOptions;

            public IntPtr GetPreferredVendorGUID;

            public IntPtr RefreshStream;
        }
    }
}
