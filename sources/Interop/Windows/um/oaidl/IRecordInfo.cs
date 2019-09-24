// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002F-0000-0000-C000-000000000046")]
    public unsafe struct IRecordInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IRecordInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IRecordInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IRecordInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RecordInit(
            [In] IRecordInfo* This,
            [Out, NativeTypeName("PVOID")] void* pvNew
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RecordClear(
            [In] IRecordInfo* This,
            [In, NativeTypeName("PVOID")] void* pvExisting
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RecordCopy(
            [In] IRecordInfo* This,
            [In, NativeTypeName("PVOID")] void* pvExisting,
            [Out, NativeTypeName("PVOID")] void* pvNew
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGuid(
            [In] IRecordInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pGuid
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetName(
            [In] IRecordInfo* This,
            [Out, NativeTypeName("BSTR")] char** pbstrName = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSize(
            [In] IRecordInfo* This,
            [Out, NativeTypeName("ULONG")] uint* pcbSize
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTypeInfo(
            [In] IRecordInfo* This,
            [Out] ITypeInfo** ppTypeInfo
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetField(
            [In] IRecordInfo* This,
            [In, NativeTypeName("PVOID")] void* pvData,
            [In, NativeTypeName("LPCOLESTR")] char* szFieldName,
            [Out] VARIANT* pvarField
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFieldNoCopy(
            [In] IRecordInfo* This,
            [In, NativeTypeName("PVOID")] void* pvData,
            [In, NativeTypeName("LPCOLESTR")] char* szFieldName,
            [Out] VARIANT* pvarField,
            [Out, NativeTypeName("PVOID")] void** ppvDataCArray
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PutField(
            [In] IRecordInfo* This,
            [In, NativeTypeName("ULONG")] uint wFlags,
            [In, Out, NativeTypeName("PVOID")] void* pvData,
            [In, NativeTypeName("LPCOLESTR")] char* szFieldName,
            [In] VARIANT* pvarField
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PutFieldNoCopy(
            [In] IRecordInfo* This,
            [In, NativeTypeName("ULONG")] uint wFlags,
            [In, Out, NativeTypeName("PVOID")] void* pvData,
            [In, NativeTypeName("LPCOLESTR")] char* szFieldName,
            [In] VARIANT* pvarField
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFieldNames(
            [In] IRecordInfo* This,
            [In, Out, NativeTypeName("ULONG")] uint* pcNames,
            [Out, NativeTypeName("BSTR[]")] char** rgBstrNames
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsMatchingType(
            [In] IRecordInfo* This,
            [In] IRecordInfo* pRecordInfo
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void* _RecordCreate(
            [In] IRecordInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RecordCreateCopy(
            [In] IRecordInfo* This,
            [In, NativeTypeName("PVOID")] void* pvSource,
            [Out, NativeTypeName("PVOID")] void** ppvDest
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RecordDestroy(
            [In] IRecordInfo* This,
            [In, NativeTypeName("PVOID")] void* pvRecord
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IRecordInfo* This = &this)
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
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordInit(
            [Out, NativeTypeName("PVOID")] void* pvNew
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordInit>(lpVtbl->RecordInit)(
                    This,
                    pvNew
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordClear(
            [In, NativeTypeName("PVOID")] void* pvExisting
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordClear>(lpVtbl->RecordClear)(
                    This,
                    pvExisting
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordCopy(
            [In, NativeTypeName("PVOID")] void* pvExisting,
            [Out, NativeTypeName("PVOID")] void* pvNew
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordCopy>(lpVtbl->RecordCopy)(
                    This,
                    pvExisting,
                    pvNew
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGuid(
            [Out, NativeTypeName("GUID")] Guid* pGuid
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGuid>(lpVtbl->GetGuid)(
                    This,
                    pGuid
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetName(
            [Out, NativeTypeName("BSTR")] char** pbstrName = null
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetName>(lpVtbl->GetName)(
                    This,
                    pbstrName
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize(
            [Out, NativeTypeName("ULONG")] uint* pcbSize
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(
                    This,
                    pcbSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(
            [Out] ITypeInfo** ppTypeInfo
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)(
                    This,
                    ppTypeInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetField(
            [In, NativeTypeName("PVOID")] void* pvData,
            [In, NativeTypeName("LPCOLESTR")] char* szFieldName,
            [Out] VARIANT* pvarField
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetField>(lpVtbl->GetField)(
                    This,
                    pvData,
                    szFieldName,
                    pvarField
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFieldNoCopy(
            [In, NativeTypeName("PVOID")] void* pvData,
            [In, NativeTypeName("LPCOLESTR")] char* szFieldName,
            [Out] VARIANT* pvarField,
            [Out, NativeTypeName("PVOID")] void** ppvDataCArray
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFieldNoCopy>(lpVtbl->GetFieldNoCopy)(
                    This,
                    pvData,
                    szFieldName,
                    pvarField,
                    ppvDataCArray
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PutField(
            [In, NativeTypeName("ULONG")] uint wFlags,
            [In, Out, NativeTypeName("PVOID")] void* pvData,
            [In, NativeTypeName("LPCOLESTR")] char* szFieldName,
            [In] VARIANT* pvarField
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PutField>(lpVtbl->PutField)(
                    This,
                    wFlags,
                    pvData,
                    szFieldName,
                    pvarField
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PutFieldNoCopy(
            [In, NativeTypeName("ULONG")] uint wFlags,
            [In, Out, NativeTypeName("PVOID")] void* pvData,
            [In, NativeTypeName("LPCOLESTR")] char* szFieldName,
            [In] VARIANT* pvarField
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PutFieldNoCopy>(lpVtbl->PutFieldNoCopy)(
                    This,
                    wFlags,
                    pvData,
                    szFieldName,
                    pvarField
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFieldNames(
            [In, Out, NativeTypeName("ULONG")] uint* pcNames,
            [Out, NativeTypeName("BSTR[]")] char** rgBstrNames
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFieldNames>(lpVtbl->GetFieldNames)(
                    This,
                    pcNames,
                    rgBstrNames
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsMatchingType(
            [In] IRecordInfo* pRecordInfo
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsMatchingType>(lpVtbl->IsMatchingType)(
                    This,
                    pRecordInfo
                );
            }
        }

        public void* RecordCreate()
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordCreate>(lpVtbl->RecordCreate)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordCreateCopy(
            [In, NativeTypeName("PVOID")] void* pvSource,
            [Out, NativeTypeName("PVOID")] void** ppvDest
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordCreateCopy>(lpVtbl->RecordCreateCopy)(
                    This,
                    pvSource,
                    ppvDest
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordDestroy(
            [In, NativeTypeName("PVOID")] void* pvRecord
        )
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordDestroy>(lpVtbl->RecordDestroy)(
                    This,
                    pvRecord
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr RecordInit;

            public IntPtr RecordClear;

            public IntPtr RecordCopy;

            public IntPtr GetGuid;

            public IntPtr GetName;

            public IntPtr GetSize;

            public IntPtr GetTypeInfo;

            public IntPtr GetField;

            public IntPtr GetFieldNoCopy;

            public IntPtr PutField;

            public IntPtr PutFieldNoCopy;

            public IntPtr GetFieldNames;

            public IntPtr IsMatchingType;

            public IntPtr RecordCreate;

            public IntPtr RecordCreateCopy;

            public IntPtr RecordDestroy;
        }
    }
}
