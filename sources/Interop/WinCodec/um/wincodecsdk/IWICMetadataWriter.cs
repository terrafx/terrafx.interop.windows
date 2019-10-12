// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F7836E16-3BE0-470B-86BB-160D0AECD7DE")]
    public unsafe partial struct IWICMetadataWriter
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICMetadataWriter* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataWriter* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataWriter* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataFormat(IWICMetadataWriter* This, [NativeTypeName("GUID")] Guid* pguidMetadataFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataHandlerInfo(IWICMetadataWriter* This, IWICMetadataHandlerInfo** ppIHandler = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCount(IWICMetadataWriter* This, [NativeTypeName("UINT")] uint* pcCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValueByIndex(IWICMetadataWriter* This, [NativeTypeName("UINT")] uint nIndex, PROPVARIANT* pvarSchema = null, PROPVARIANT* pvarId = null, PROPVARIANT* pvarValue = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValue(IWICMetadataWriter* This, [Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEnumerator(IWICMetadataWriter* This, IWICEnumMetadataItem** ppIEnumMetadata = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetValue(IWICMetadataWriter* This, [Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetValueByIndex(IWICMetadataWriter* This, [NativeTypeName("UINT")] uint nIndex, [Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveValue(IWICMetadataWriter* This, [Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveValueByIndex(IWICMetadataWriter* This, [NativeTypeName("UINT")] uint nIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID")] Guid* pguidMetadataFormat)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataFormat>(lpVtbl->GetMetadataFormat)(This, pguidMetadataFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler = null)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataHandlerInfo>(lpVtbl->GetMetadataHandlerInfo)(This, ppIHandler);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT")] uint* pcCount)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)(This, pcCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex([NativeTypeName("UINT")] uint nIndex, PROPVARIANT* pvarSchema = null, PROPVARIANT* pvarId = null, PROPVARIANT* pvarValue = null)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValueByIndex>(lpVtbl->GetValueByIndex)(This, nIndex, pvarSchema, pvarId, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue = null)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValue>(lpVtbl->GetValue)(This, pvarSchema, pvarId, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata = null)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)(This, ppIEnumMetadata);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetValue>(lpVtbl->SetValue)(This, pvarSchema, pvarId, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByIndex([NativeTypeName("UINT")] uint nIndex, [Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetValueByIndex>(lpVtbl->SetValueByIndex)(This, nIndex, pvarSchema, pvarId, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValue([Optional] PROPVARIANT* pvarSchema, PROPVARIANT* pvarId)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveValue>(lpVtbl->RemoveValue)(This, pvarSchema, pvarId);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValueByIndex([NativeTypeName("UINT")] uint nIndex)
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveValueByIndex>(lpVtbl->RemoveValueByIndex)(This, nIndex);
            }
        }

        public partial struct Vtbl
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

            public IntPtr SetValue;

            public IntPtr SetValueByIndex;

            public IntPtr RemoveValue;

            public IntPtr RemoveValueByIndex;
        }
    }
}
