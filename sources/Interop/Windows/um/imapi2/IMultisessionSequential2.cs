// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B507CA22-2204-11DD-966A-001AA01BBC58")]
    [NativeTypeName("struct IMultisessionSequential2 : IMultisessionSequential")]
    [NativeInheritance("IMultisessionSequential")]
    public unsafe partial struct IMultisessionSequential2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, Guid*, void**, int>)(lpVtbl[0]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, uint>)(lpVtbl[1]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, uint>)(lpVtbl[2]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, uint*, int>)(lpVtbl[3]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsSupportedOnCurrentMediaState([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, short*, int>)(lpVtbl[7]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int put_InUse([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, short, int>)(lpVtbl[8]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_InUse([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, short*, int>)(lpVtbl[9]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_ImportRecorder(IDiscRecorder2** value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, IDiscRecorder2**, int>)(lpVtbl[10]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsFirstDataSession([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, short*, int>)(lpVtbl[11]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_StartAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, int*, int>)(lpVtbl[12]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastWrittenAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, int*, int>)(lpVtbl[13]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_NextWritableAddress([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, int*, int>)(lpVtbl[14]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, int*, int>)(lpVtbl[15]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_WriteUnitSize([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IMultisessionSequential2*, int*, int>)(lpVtbl[16]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
