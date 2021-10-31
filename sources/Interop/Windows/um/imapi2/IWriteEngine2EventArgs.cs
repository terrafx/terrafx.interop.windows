// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354136-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IWriteEngine2EventArgs : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IWriteEngine2EventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, uint>)(lpVtbl[1]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, uint>)(lpVtbl[2]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, uint*, int>)(lpVtbl[3]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_StartLba([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[7]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_SectorCount([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[8]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_LastReadLba([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[9]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_LastWrittenLba([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[10]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_TotalSystemBuffer([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[11]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_UsedSystemBuffer([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[12]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_FreeSystemBuffer([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[13]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
