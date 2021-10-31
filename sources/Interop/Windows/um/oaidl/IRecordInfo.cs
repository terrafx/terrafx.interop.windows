// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002F-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IRecordInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRecordInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRecordInfo*, Guid*, void**, int>)(lpVtbl[0]))((IRecordInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRecordInfo*, uint>)(lpVtbl[1]))((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRecordInfo*, uint>)(lpVtbl[2]))((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int RecordInit([NativeTypeName("PVOID")] void* pvNew)
        {
            return ((delegate* unmanaged<IRecordInfo*, void*, int>)(lpVtbl[3]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int RecordClear([NativeTypeName("PVOID")] void* pvExisting)
        {
            return ((delegate* unmanaged<IRecordInfo*, void*, int>)(lpVtbl[4]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RecordCopy([NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew)
        {
            return ((delegate* unmanaged<IRecordInfo*, void*, void*, int>)(lpVtbl[5]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting, pvNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<IRecordInfo*, Guid*, int>)(lpVtbl[6]))((IRecordInfo*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<IRecordInfo*, ushort**, int>)(lpVtbl[7]))((IRecordInfo*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("ULONG *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IRecordInfo*, uint*, int>)(lpVtbl[8]))((IRecordInfo*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(ITypeInfo** ppTypeInfo)
        {
            return ((delegate* unmanaged<IRecordInfo*, ITypeInfo**, int>)(lpVtbl[9]))((IRecordInfo*)Unsafe.AsPointer(ref this), ppTypeInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetField([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField)
        {
            return ((delegate* unmanaged<IRecordInfo*, void*, ushort*, VARIANT*, int>)(lpVtbl[10]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldNoCopy([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField, [NativeTypeName("PVOID *")] void** ppvDataCArray)
        {
            return ((delegate* unmanaged<IRecordInfo*, void*, ushort*, VARIANT*, void**, int>)(lpVtbl[11]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField, ppvDataCArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int PutField([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField)
        {
            return ((delegate* unmanaged<IRecordInfo*, uint, void*, ushort*, VARIANT*, int>)(lpVtbl[12]))((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int PutFieldNoCopy([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField)
        {
            return ((delegate* unmanaged<IRecordInfo*, uint, void*, ushort*, VARIANT*, int>)(lpVtbl[13]))((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldNames([NativeTypeName("ULONG *")] uint* pcNames, [NativeTypeName("BSTR *")] ushort** rgBstrNames)
        {
            return ((delegate* unmanaged<IRecordInfo*, uint*, ushort**, int>)(lpVtbl[14]))((IRecordInfo*)Unsafe.AsPointer(ref this), pcNames, rgBstrNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public BOOL IsMatchingType(IRecordInfo* pRecordInfo)
        {
            return ((delegate* unmanaged<IRecordInfo*, IRecordInfo*, int>)(lpVtbl[15]))((IRecordInfo*)Unsafe.AsPointer(ref this), pRecordInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("PVOID")]
        public void* RecordCreate()
        {
            return ((delegate* unmanaged<IRecordInfo*, void*>)(lpVtbl[16]))((IRecordInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int RecordCreateCopy([NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID *")] void** ppvDest)
        {
            return ((delegate* unmanaged<IRecordInfo*, void*, void**, int>)(lpVtbl[17]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvSource, ppvDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int RecordDestroy([NativeTypeName("PVOID")] void* pvRecord)
        {
            return ((delegate* unmanaged<IRecordInfo*, void*, int>)(lpVtbl[18]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvRecord);
        }
    }
}
