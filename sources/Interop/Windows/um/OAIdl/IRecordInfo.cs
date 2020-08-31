// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002F-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IRecordInfo : IUnknown")]
    public unsafe partial struct IRecordInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IRecordInfo*, Guid*, void**, int>)(lpVtbl[0]))((IRecordInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IRecordInfo*, uint>)(lpVtbl[1]))((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IRecordInfo*, uint>)(lpVtbl[2]))((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RecordInit([NativeTypeName("PVOID")] void* pvNew)
        {
            return ((delegate* stdcall<IRecordInfo*, void*, int>)(lpVtbl[3]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RecordClear([NativeTypeName("PVOID")] void* pvExisting)
        {
            return ((delegate* stdcall<IRecordInfo*, void*, int>)(lpVtbl[4]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RecordCopy([NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew)
        {
            return ((delegate* stdcall<IRecordInfo*, void*, void*, int>)(lpVtbl[5]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting, pvNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* stdcall<IRecordInfo*, Guid*, int>)(lpVtbl[6]))((IRecordInfo*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* stdcall<IRecordInfo*, ushort**, int>)(lpVtbl[7]))((IRecordInfo*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("ULONG *")] uint* pcbSize)
        {
            return ((delegate* stdcall<IRecordInfo*, uint*, int>)(lpVtbl[8]))((IRecordInfo*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTypeInfo)
        {
            return ((delegate* stdcall<IRecordInfo*, ITypeInfo**, int>)(lpVtbl[9]))((IRecordInfo*)Unsafe.AsPointer(ref this), ppTypeInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetField([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return ((delegate* stdcall<IRecordInfo*, void*, ushort*, VARIANT*, int>)(lpVtbl[10]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldNoCopy([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField, [NativeTypeName("PVOID *")] void** ppvDataCArray)
        {
            return ((delegate* stdcall<IRecordInfo*, void*, ushort*, VARIANT*, void**, int>)(lpVtbl[11]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField, ppvDataCArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutField([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return ((delegate* stdcall<IRecordInfo*, uint, void*, ushort*, VARIANT*, int>)(lpVtbl[12]))((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutFieldNoCopy([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, [NativeTypeName("VARIANT *")] VARIANT* pvarField)
        {
            return ((delegate* stdcall<IRecordInfo*, uint, void*, ushort*, VARIANT*, int>)(lpVtbl[13]))((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldNames([NativeTypeName("ULONG *")] uint* pcNames, [NativeTypeName("BSTR *")] ushort** rgBstrNames)
        {
            return ((delegate* stdcall<IRecordInfo*, uint*, ushort**, int>)(lpVtbl[14]))((IRecordInfo*)Unsafe.AsPointer(ref this), pcNames, rgBstrNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsMatchingType([NativeTypeName("IRecordInfo *")] IRecordInfo* pRecordInfo)
        {
            return ((delegate* stdcall<IRecordInfo*, IRecordInfo*, int>)(lpVtbl[15]))((IRecordInfo*)Unsafe.AsPointer(ref this), pRecordInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("PVOID")]
        public void* RecordCreate()
        {
            return ((delegate* stdcall<IRecordInfo*, void*>)(lpVtbl[16]))((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RecordCreateCopy([NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID *")] void** ppvDest)
        {
            return ((delegate* stdcall<IRecordInfo*, void*, void**, int>)(lpVtbl[17]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvSource, ppvDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RecordDestroy([NativeTypeName("PVOID")] void* pvRecord)
        {
            return ((delegate* stdcall<IRecordInfo*, void*, int>)(lpVtbl[18]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvRecord);
        }
    }
}
