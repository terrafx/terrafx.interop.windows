// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2735413D-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IDiscFormat2DataEventArgs : IWriteEngine2EventArgs")]
    [NativeInheritance("IWriteEngine2EventArgs")]
    public unsafe partial struct IDiscFormat2DataEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, uint>)(lpVtbl[1]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, uint>)(lpVtbl[2]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, uint*, int>)(lpVtbl[3]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_StartLba([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[7]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_SectorCount([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[8]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_LastReadLba([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[9]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_LastWrittenLba([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[10]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_TotalSystemBuffer([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[11]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_UsedSystemBuffer([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[12]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_FreeSystemBuffer([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[13]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_ElapsedTime([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[14]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_RemainingTime([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[15]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_TotalTime([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int>)(lpVtbl[16]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_CurrentAction(IMAPI_FORMAT2_DATA_WRITE_ACTION* value)
        {
            return ((delegate* unmanaged<IDiscFormat2DataEventArgs*, IMAPI_FORMAT2_DATA_WRITE_ACTION*, int>)(lpVtbl[17]))((IDiscFormat2DataEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_StartLba;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_SectorCount;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_LastReadLba;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_LastWrittenLba;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_TotalSystemBuffer;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_UsedSystemBuffer;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_FreeSystemBuffer;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_ElapsedTime;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_RemainingTime;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, int*, int> get_TotalTime;

            [NativeTypeName("HRESULT (IMAPI_FORMAT2_DATA_WRITE_ACTION *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiscFormat2DataEventArgs*, IMAPI_FORMAT2_DATA_WRITE_ACTION*, int> get_CurrentAction;
        }
    }
}
