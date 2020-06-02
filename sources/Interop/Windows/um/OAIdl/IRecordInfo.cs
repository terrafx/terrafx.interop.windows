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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IRecordInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordInit([NativeTypeName("PVOID")] void* pvNew)
        {
            return lpVtbl->RecordInit((IRecordInfo*)Unsafe.AsPointer(ref this), pvNew);
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordClear([NativeTypeName("PVOID")] void* pvExisting)
        {
            return lpVtbl->RecordClear((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting);
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordCopy([NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew)
        {
            return lpVtbl->RecordCopy((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting, pvNew);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID *")] Guid* pguid)
        {
            return lpVtbl->GetGuid((IRecordInfo*)Unsafe.AsPointer(ref this), pguid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return lpVtbl->GetName((IRecordInfo*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("ULONG *")] uint* pcbSize)
        {
            return lpVtbl->GetSize((IRecordInfo*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTypeInfo)
        {
            return lpVtbl->GetTypeInfo((IRecordInfo*)Unsafe.AsPointer(ref this), ppTypeInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetField([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return lpVtbl->GetField((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFieldNoCopy([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField, [NativeTypeName("PVOID *")] void** ppvDataCArray)
        {
            return lpVtbl->GetFieldNoCopy((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField, ppvDataCArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int PutField([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return lpVtbl->PutField((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
        }

        [return: NativeTypeName("HRESULT")]
        public int PutFieldNoCopy([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return lpVtbl->PutFieldNoCopy((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFieldNames([NativeTypeName("ULONG *")] uint* pcNames, [NativeTypeName("BSTR *")] ushort** rgBstrNames)
        {
            return lpVtbl->GetFieldNames((IRecordInfo*)Unsafe.AsPointer(ref this), pcNames, rgBstrNames);
        }

        [return: NativeTypeName("BOOL")]
        public int IsMatchingType([NativeTypeName("IRecordInfo *")] IRecordInfo* pRecordInfo)
        {
            return lpVtbl->IsMatchingType((IRecordInfo*)Unsafe.AsPointer(ref this), pRecordInfo);
        }

        [return: NativeTypeName("PVOID")]
        public void* RecordCreate()
        {
            return lpVtbl->RecordCreate((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordCreateCopy([NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID *")] void** ppvDest)
        {
            return lpVtbl->RecordCreateCopy((IRecordInfo*)Unsafe.AsPointer(ref this), pvSource, ppvDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int RecordDestroy([NativeTypeName("PVOID")] void* pvRecord)
        {
            return lpVtbl->RecordDestroy((IRecordInfo*)Unsafe.AsPointer(ref this), pvRecord);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, uint> Release;

            [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, void*, int> RecordInit;

            [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, void*, int> RecordClear;

            [NativeTypeName("HRESULT (PVOID, PVOID) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, void*, void*, int> RecordCopy;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, Guid*, int> GetGuid;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, ushort**, int> GetName;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, void*, ushort*, VARIANT*, int> GetField;

            [NativeTypeName("HRESULT (PVOID, LPCOLESTR, VARIANT *, PVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, void*, ushort*, VARIANT*, void**, int> GetFieldNoCopy;

            [NativeTypeName("HRESULT (ULONG, PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, uint, void*, ushort*, VARIANT*, int> PutField;

            [NativeTypeName("HRESULT (ULONG, PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, uint, void*, ushort*, VARIANT*, int> PutFieldNoCopy;

            [NativeTypeName("HRESULT (ULONG *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, uint*, ushort**, int> GetFieldNames;

            [NativeTypeName("BOOL (IRecordInfo *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, IRecordInfo*, int> IsMatchingType;

            [NativeTypeName("PVOID () __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, void*> RecordCreate;

            [NativeTypeName("HRESULT (PVOID, PVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, void*, void**, int> RecordCreateCopy;

            [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
            public delegate* stdcall<IRecordInfo*, void*, int> RecordDestroy;
        }
    }
}
