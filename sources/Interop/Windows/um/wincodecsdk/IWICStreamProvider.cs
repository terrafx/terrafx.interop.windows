// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("449494BC-B468-4927-96D7-BA90D31AB505")]
    public unsafe struct IWICStreamProvider
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICStreamProvider* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICStreamProvider* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICStreamProvider* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetStream(
            [In] IWICStreamProvider* This,
            [Out] IStream** ppIStream = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPersistOptions(
            [In] IWICStreamProvider* This,
            [Out, NativeTypeName("DWORD")] uint* pdwPersistOptions
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPreferredVendorGUID(
            [In] IWICStreamProvider* This,
            [Out, NativeTypeName("GUID")] Guid* pguidPreferredVendor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RefreshStream(
            [In] IWICStreamProvider* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStream(
            [Out] IStream** ppIStream = null
        )
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStream>(lpVtbl->GetStream)(
                    This,
                    ppIStream
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPersistOptions(
            [Out, NativeTypeName("DWORD")] uint* pdwPersistOptions
        )
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPersistOptions>(lpVtbl->GetPersistOptions)(
                    This,
                    pdwPersistOptions
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreferredVendorGUID(
            [Out, NativeTypeName("GUID")] Guid* pguidPreferredVendor
        )
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPreferredVendorGUID>(lpVtbl->GetPreferredVendorGUID)(
                    This,
                    pguidPreferredVendor
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RefreshStream()
        {
            fixed (IWICStreamProvider* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RefreshStream>(lpVtbl->RefreshStream)(
                    This
                );
            }
        }

        public struct Vtbl
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
