// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C941FD7-975B-59BE-A960-9A2A262853A5")]
    [NativeTypeName("struct IProgressItems : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IProgressItems
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProgressItems*, Guid*, void**, int>)(lpVtbl[0]))((IProgressItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProgressItems*, uint>)(lpVtbl[1]))((IProgressItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProgressItems*, uint>)(lpVtbl[2]))((IProgressItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IProgressItems*, uint*, int>)(lpVtbl[3]))((IProgressItems*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IProgressItems*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IProgressItems*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IProgressItems*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IProgressItems*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IProgressItems*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IProgressItems*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get__NewEnum(IEnumVARIANT** NewEnum)
        {
            return ((delegate* unmanaged<IProgressItems*, IEnumVARIANT**, int>)(lpVtbl[7]))((IProgressItems*)Unsafe.AsPointer(ref this), NewEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Item([NativeTypeName("long")] int Index, IProgressItem** item)
        {
            return ((delegate* unmanaged<IProgressItems*, int, IProgressItem**, int>)(lpVtbl[8]))((IProgressItems*)Unsafe.AsPointer(ref this), Index, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* unmanaged<IProgressItems*, int*, int>)(lpVtbl[9]))((IProgressItems*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT ProgressItemFromBlock([NativeTypeName("ULONG")] uint block, IProgressItem** item)
        {
            return ((delegate* unmanaged<IProgressItems*, uint, IProgressItem**, int>)(lpVtbl[10]))((IProgressItems*)Unsafe.AsPointer(ref this), block, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT ProgressItemFromDescription([NativeTypeName("BSTR")] ushort* description, IProgressItem** item)
        {
            return ((delegate* unmanaged<IProgressItems*, ushort*, IProgressItem**, int>)(lpVtbl[11]))((IProgressItems*)Unsafe.AsPointer(ref this), description, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_EnumProgressItems(IEnumProgressItems** NewEnum)
        {
            return ((delegate* unmanaged<IProgressItems*, IEnumProgressItems**, int>)(lpVtbl[12]))((IProgressItems*)Unsafe.AsPointer(ref this), NewEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IEnumVARIANT **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, IEnumVARIANT**, int> get__NewEnum;

            [NativeTypeName("HRESULT (long, IProgressItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, int, IProgressItem**, int> get_Item;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, int*, int> get_Count;

            [NativeTypeName("HRESULT (ULONG, IProgressItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, uint, IProgressItem**, int> ProgressItemFromBlock;

            [NativeTypeName("HRESULT (BSTR, IProgressItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, ushort*, IProgressItem**, int> ProgressItemFromDescription;

            [NativeTypeName("HRESULT (IEnumProgressItems **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProgressItems*, IEnumProgressItems**, int> get_EnumProgressItems;
        }
    }
}
