// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002F-0000-0000-C000-000000000046")]
    public unsafe partial struct IRecordInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IRecordInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRecordInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRecordInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordInit(IRecordInfo* pThis, [NativeTypeName("PVOID")] void* pvNew);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordClear(IRecordInfo* pThis, [NativeTypeName("PVOID")] void* pvExisting);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordCopy(IRecordInfo* pThis, [NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGuid(IRecordInfo* pThis, [NativeTypeName("GUID *")] Guid* pguid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetName(IRecordInfo* pThis, [NativeTypeName("BSTR *")] ushort** pbstrName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IRecordInfo* pThis, [NativeTypeName("ULONG *")] uint* pcbSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(IRecordInfo* pThis, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTypeInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetField(IRecordInfo* pThis, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFieldNoCopy(IRecordInfo* pThis, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField, [NativeTypeName("PVOID *")] void** ppvDataCArray);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PutField(IRecordInfo* pThis, [NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PutFieldNoCopy(IRecordInfo* pThis, [NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFieldNames(IRecordInfo* pThis, [NativeTypeName("ULONG *")] uint* pcNames, [NativeTypeName("BSTR *")] ushort** rgBstrNames);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsMatchingType(IRecordInfo* pThis, [NativeTypeName("IRecordInfo *")] IRecordInfo* pRecordInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("PVOID")]
        public delegate void* _RecordCreate(IRecordInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordCreateCopy(IRecordInfo* pThis, [NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID *")] void** ppvDest);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RecordDestroy(IRecordInfo* pThis, [NativeTypeName("PVOID")] void* pvRecord);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IRecordInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordInit([NativeTypeName("PVOID")] void* pvNew)
        {
            return Marshal.GetDelegateForFunctionPointer<_RecordInit>(lpVtbl->RecordInit)((IRecordInfo*)Unsafe.AsPointer(ref this), pvNew);
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordClear([NativeTypeName("PVOID")] void* pvExisting)
        {
            return Marshal.GetDelegateForFunctionPointer<_RecordClear>(lpVtbl->RecordClear)((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting);
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordCopy([NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew)
        {
            return Marshal.GetDelegateForFunctionPointer<_RecordCopy>(lpVtbl->RecordCopy)((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting, pvNew);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID *")] Guid* pguid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGuid>(lpVtbl->GetGuid)((IRecordInfo*)Unsafe.AsPointer(ref this), pguid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetName>(lpVtbl->GetName)((IRecordInfo*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("ULONG *")] uint* pcbSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)((IRecordInfo*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTypeInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)((IRecordInfo*)Unsafe.AsPointer(ref this), ppTypeInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetField([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetField>(lpVtbl->GetField)((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFieldNoCopy([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField, [NativeTypeName("PVOID *")] void** ppvDataCArray)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFieldNoCopy>(lpVtbl->GetFieldNoCopy)((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField, ppvDataCArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int PutField([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return Marshal.GetDelegateForFunctionPointer<_PutField>(lpVtbl->PutField)((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
        }

        [return: NativeTypeName("HRESULT")]
        public int PutFieldNoCopy([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return Marshal.GetDelegateForFunctionPointer<_PutFieldNoCopy>(lpVtbl->PutFieldNoCopy)((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFieldNames([NativeTypeName("ULONG *")] uint* pcNames, [NativeTypeName("BSTR *")] ushort** rgBstrNames)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFieldNames>(lpVtbl->GetFieldNames)((IRecordInfo*)Unsafe.AsPointer(ref this), pcNames, rgBstrNames);
        }

        [return: NativeTypeName("BOOL")]
        public int IsMatchingType([NativeTypeName("IRecordInfo *")] IRecordInfo* pRecordInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsMatchingType>(lpVtbl->IsMatchingType)((IRecordInfo*)Unsafe.AsPointer(ref this), pRecordInfo);
        }

        [return: NativeTypeName("PVOID")]
        public void* RecordCreate()
        {
            return Marshal.GetDelegateForFunctionPointer<_RecordCreate>(lpVtbl->RecordCreate)((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordCreateCopy([NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID *")] void** ppvDest)
        {
            return Marshal.GetDelegateForFunctionPointer<_RecordCreateCopy>(lpVtbl->RecordCreateCopy)((IRecordInfo*)Unsafe.AsPointer(ref this), pvSource, ppvDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordDestroy([NativeTypeName("PVOID")] void* pvRecord)
        {
            return Marshal.GetDelegateForFunctionPointer<_RecordDestroy>(lpVtbl->RecordDestroy)((IRecordInfo*)Unsafe.AsPointer(ref this), pvRecord);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
            public IntPtr RecordInit;

            [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
            public IntPtr RecordClear;

            [NativeTypeName("HRESULT (PVOID, PVOID) __attribute__((stdcall))")]
            public IntPtr RecordCopy;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetGuid;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetName;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public IntPtr GetSize;

            [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetTypeInfo;

            [NativeTypeName("HRESULT (PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public IntPtr GetField;

            [NativeTypeName("HRESULT (PVOID, LPCOLESTR, VARIANT *, PVOID *) __attribute__((stdcall))")]
            public IntPtr GetFieldNoCopy;

            [NativeTypeName("HRESULT (ULONG, PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public IntPtr PutField;

            [NativeTypeName("HRESULT (ULONG, PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public IntPtr PutFieldNoCopy;

            [NativeTypeName("HRESULT (ULONG *, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetFieldNames;

            [NativeTypeName("BOOL (IRecordInfo *) __attribute__((stdcall))")]
            public IntPtr IsMatchingType;

            [NativeTypeName("PVOID () __attribute__((stdcall))")]
            public IntPtr RecordCreate;

            [NativeTypeName("HRESULT (PVOID, PVOID *) __attribute__((stdcall))")]
            public IntPtr RecordCreateCopy;

            [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
            public IntPtr RecordDestroy;
        }
    }
}
