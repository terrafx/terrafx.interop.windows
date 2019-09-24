// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F7836E16-3BE0-470B-86BB-160D0AECD7DE")]
    public unsafe struct IWICMetadataWriter
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICMetadataWriter* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICMetadataWriter* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICMetadataWriter* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetadataFormat(
            [In] IWICMetadataWriter* This,
            [Out, NativeTypeName("GUID")] Guid* pguidMetadataFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetadataHandlerInfo(
            [In] IWICMetadataWriter* This,
            [Out] IWICMetadataHandlerInfo** ppIHandler = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCount(
            [In] IWICMetadataWriter* This,
            [Out, NativeTypeName("UINT")] uint* pcCount
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetValueByIndex(
            [In] IWICMetadataWriter* This,
            [In, NativeTypeName("UINT")] uint nIndex,
            [In, Out] PROPVARIANT* pvarSchema = null,
            [In, Out] PROPVARIANT* pvarId = null,
            [In, Out] PROPVARIANT* pvarValue = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetValue(
            [In] IWICMetadataWriter* This,
            [In, Optional] PROPVARIANT* pvarSchema,
            [In] PROPVARIANT* pvarId,
            [In, Out] PROPVARIANT* pvarValue = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetEnumerator(
            [In] IWICMetadataWriter* This,
            [Out] IWICEnumMetadataItem** ppIEnumMetadata = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetValue(
            [In] IWICMetadataWriter* This,
            [In, Optional] PROPVARIANT* pvarSchema,
            [In] PROPVARIANT* pvarId,
            [In] PROPVARIANT* pvarValue
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetValueByIndex(
            [In] IWICMetadataWriter* This,
            [In, NativeTypeName("UINT")] uint nIndex,
            [In, Optional] PROPVARIANT* pvarSchema,
            [In] PROPVARIANT* pvarId,
            [In] PROPVARIANT* pvarValue
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveValue(
            [In] IWICMetadataWriter* This,
            [In, Optional] PROPVARIANT* pvarSchema,
            [In] PROPVARIANT* pvarId
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveValueByIndex(
            [In] IWICMetadataWriter* This,
            [In, NativeTypeName("UINT")] uint nIndex
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICMetadataWriter* This = &this)
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
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat(
            [Out, NativeTypeName("GUID")] Guid* pguidMetadataFormat
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataFormat>(lpVtbl->GetMetadataFormat)(
                    This,
                    pguidMetadataFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo(
            [Out] IWICMetadataHandlerInfo** ppIHandler = null
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataHandlerInfo>(lpVtbl->GetMetadataHandlerInfo)(
                    This,
                    ppIHandler
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount(
            [Out, NativeTypeName("UINT")] uint* pcCount
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)(
                    This,
                    pcCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex(
            [In, NativeTypeName("UINT")] uint nIndex,
            [In, Out] PROPVARIANT* pvarSchema = null,
            [In, Out] PROPVARIANT* pvarId = null,
            [In, Out] PROPVARIANT* pvarValue = null
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValueByIndex>(lpVtbl->GetValueByIndex)(
                    This,
                    nIndex,
                    pvarSchema,
                    pvarId,
                    pvarValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue(
            [In, Optional] PROPVARIANT* pvarSchema,
            [In] PROPVARIANT* pvarId,
            [In, Out] PROPVARIANT* pvarValue = null
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValue>(lpVtbl->GetValue)(
                    This,
                    pvarSchema,
                    pvarId,
                    pvarValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(
            [Out] IWICEnumMetadataItem** ppIEnumMetadata = null
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)(
                    This,
                    ppIEnumMetadata
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue(
            [In, Optional] PROPVARIANT* pvarSchema,
            [In] PROPVARIANT* pvarId,
            [In] PROPVARIANT* pvarValue
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetValue>(lpVtbl->SetValue)(
                    This,
                    pvarSchema,
                    pvarId,
                    pvarValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByIndex(
            [In, NativeTypeName("UINT")] uint nIndex,
            [In, Optional] PROPVARIANT* pvarSchema,
            [In] PROPVARIANT* pvarId,
            [In] PROPVARIANT* pvarValue
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetValueByIndex>(lpVtbl->SetValueByIndex)(
                    This,
                    nIndex,
                    pvarSchema,
                    pvarId,
                    pvarValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValue(
            [In, Optional] PROPVARIANT* pvarSchema,
            [In] PROPVARIANT* pvarId
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveValue>(lpVtbl->RemoveValue)(
                    This,
                    pvarSchema,
                    pvarId
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValueByIndex(
            [In, NativeTypeName("UINT")] uint nIndex
        )
        {
            fixed (IWICMetadataWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveValueByIndex>(lpVtbl->RemoveValueByIndex)(
                    This,
                    nIndex
                );
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

            public IntPtr SetValue;

            public IntPtr SetValueByIndex;

            public IntPtr RemoveValue;

            public IntPtr RemoveValueByIndex;
        }
    }
}
