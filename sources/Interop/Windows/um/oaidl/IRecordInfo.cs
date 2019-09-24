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
        public delegate int _QueryInterface(IRecordInfo* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRecordInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRecordInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordInit(IRecordInfo* This, [NativeTypeName("PVOID")] void* pvNew);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordClear(IRecordInfo* This, [NativeTypeName("PVOID")] void* pvExisting);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordCopy(IRecordInfo* This, [NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGuid(IRecordInfo* This, [NativeTypeName("GUID")] Guid* pGuid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetName(IRecordInfo* This, [NativeTypeName("BSTR")] char** pbstrName = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IRecordInfo* This, [NativeTypeName("ULONG")] uint* pcbSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(IRecordInfo* This, ITypeInfo** ppTypeInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetField(IRecordInfo* This, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] char* szFieldName, VARIANT* pvarField);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFieldNoCopy(IRecordInfo* This, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] char* szFieldName, VARIANT* pvarField, [NativeTypeName("PVOID")] void** ppvDataCArray);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PutField(IRecordInfo* This, [NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] char* szFieldName, VARIANT* pvarField);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PutFieldNoCopy(IRecordInfo* This, [NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] char* szFieldName, VARIANT* pvarField);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFieldNames(IRecordInfo* This, [NativeTypeName("ULONG")] uint* pcNames, [NativeTypeName("BSTR[]")] char** rgBstrNames);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsMatchingType(IRecordInfo* This, IRecordInfo* pRecordInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void* _RecordCreate(IRecordInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordCreateCopy(IRecordInfo* This, [NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID")] void** ppvDest);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordDestroy(IRecordInfo* This, [NativeTypeName("PVOID")] void* pvRecord);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordInit([NativeTypeName("PVOID")] void* pvNew)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordInit>(lpVtbl->RecordInit)(This, pvNew);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordClear([NativeTypeName("PVOID")] void* pvExisting)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordClear>(lpVtbl->RecordClear)(This, pvExisting);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordCopy([NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordCopy>(lpVtbl->RecordCopy)(This, pvExisting, pvNew);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID")] Guid* pGuid)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGuid>(lpVtbl->GetGuid)(This, pGuid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("BSTR")] char** pbstrName = null)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetName>(lpVtbl->GetName)(This, pbstrName);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("ULONG")] uint* pcbSize)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(This, pcbSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(ITypeInfo** ppTypeInfo)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)(This, ppTypeInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetField([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] char* szFieldName, VARIANT* pvarField)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetField>(lpVtbl->GetField)(This, pvData, szFieldName, pvarField);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFieldNoCopy([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] char* szFieldName, VARIANT* pvarField, [NativeTypeName("PVOID")] void** ppvDataCArray)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFieldNoCopy>(lpVtbl->GetFieldNoCopy)(This, pvData, szFieldName, pvarField, ppvDataCArray);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PutField([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] char* szFieldName, VARIANT* pvarField)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PutField>(lpVtbl->PutField)(This, wFlags, pvData, szFieldName, pvarField);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PutFieldNoCopy([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] char* szFieldName, VARIANT* pvarField)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PutFieldNoCopy>(lpVtbl->PutFieldNoCopy)(This, wFlags, pvData, szFieldName, pvarField);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFieldNames([NativeTypeName("ULONG")] uint* pcNames, [NativeTypeName("BSTR[]")] char** rgBstrNames)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFieldNames>(lpVtbl->GetFieldNames)(This, pcNames, rgBstrNames);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsMatchingType(IRecordInfo* pRecordInfo)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsMatchingType>(lpVtbl->IsMatchingType)(This, pRecordInfo);
            }
        }

        public void* RecordCreate()
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordCreate>(lpVtbl->RecordCreate)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordCreateCopy([NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID")] void** ppvDest)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordCreateCopy>(lpVtbl->RecordCreateCopy)(This, pvSource, ppvDest);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordDestroy([NativeTypeName("PVOID")] void* pvRecord)
        {
            fixed (IRecordInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RecordDestroy>(lpVtbl->RecordDestroy)(This, pvRecord);
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
