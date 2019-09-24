// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9204FE99-D8FC-4FD5-A001-9536B067A899")]
    public unsafe struct IWICMetadataReader
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICMetadataReader* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataReader* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataReader* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataFormat(IWICMetadataReader* This, [NativeTypeName("GUID")] Guid* pguidMetadataFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataHandlerInfo(IWICMetadataReader* This, IWICMetadataHandlerInfo** ppIHandler = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCount(IWICMetadataReader* This, [NativeTypeName("UINT")] uint* pcCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValueByIndex(IWICMetadataReader* This, [NativeTypeName("UINT")] uint nIndex, PROPVARIANT* pvarSchema = null, PROPVARIANT* pvarId = null, PROPVARIANT* pvarValue = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValue(IWICMetadataReader* This, [Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEnumerator(IWICMetadataReader* This, IWICEnumMetadataItem** ppIEnumMetadata = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID")] Guid* pguidMetadataFormat)
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataFormat>(lpVtbl->GetMetadataFormat)(This, pguidMetadataFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler = null)
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataHandlerInfo>(lpVtbl->GetMetadataHandlerInfo)(This, ppIHandler);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT")] uint* pcCount)
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)(This, pcCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex([NativeTypeName("UINT")] uint nIndex, PROPVARIANT* pvarSchema = null, PROPVARIANT* pvarId = null, PROPVARIANT* pvarValue = null)
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValueByIndex>(lpVtbl->GetValueByIndex)(This, nIndex, pvarSchema, pvarId, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue = null)
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValue>(lpVtbl->GetValue)(This, pvarSchema, pvarId, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata = null)
        {
            fixed (IWICMetadataReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)(This, ppIEnumMetadata);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetMetadataFormat;

            public IntPtr GetMetadataHandlerInfo;

            public IntPtr GetCount;

            public IntPtr GetValueByIndex;

            public IntPtr GetValue;

            public IntPtr GetEnumerator;
        }
    }
}
