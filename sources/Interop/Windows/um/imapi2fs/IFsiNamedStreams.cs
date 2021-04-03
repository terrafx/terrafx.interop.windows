// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ED79BA56-5294-4250-8D46-F9AECEE23459")]
    [NativeTypeName("struct IFsiNamedStreams : IDispatch")]
    public unsafe partial struct IFsiNamedStreams
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, Guid*, void**, int>)(lpVtbl[0]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, uint>)(lpVtbl[1]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, uint>)(lpVtbl[2]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, uint*, int>)(lpVtbl[3]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IEnumVARIANT** NewEnum)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, IEnumVARIANT**, int>)(lpVtbl[7]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), NewEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Item([NativeTypeName("LONG")] int index, IFsiFileItem2** item)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, int, IFsiFileItem2**, int>)(lpVtbl[8]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), index, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("LONG *")] int* count)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, int*, int>)(lpVtbl[9]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EnumNamedStreams(IEnumFsiItems** NewEnum)
        {
            return ((delegate* unmanaged<IFsiNamedStreams*, IEnumFsiItems**, int>)(lpVtbl[10]))((IFsiNamedStreams*)Unsafe.AsPointer(ref this), NewEnum);
        }
    }
}
