// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C941FD7-975B-59BE-A960-9A2A262853A5")]
    [NativeTypeName("struct IProgressItems : IDispatch")]
    public unsafe partial struct IProgressItems
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IProgressItems*, Guid*, void**, int>)(lpVtbl[0]))((IProgressItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProgressItems*, uint>)(lpVtbl[1]))((IProgressItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProgressItems*, uint>)(lpVtbl[2]))((IProgressItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IProgressItems*, uint*, int>)(lpVtbl[3]))((IProgressItems*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IProgressItems*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IProgressItems*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IProgressItems*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IProgressItems*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IProgressItems*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IProgressItems*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum([NativeTypeName("IEnumVARIANT **")] IEnumVARIANT** NewEnum)
        {
            return ((delegate* unmanaged<IProgressItems*, IEnumVARIANT**, int>)(lpVtbl[7]))((IProgressItems*)Unsafe.AsPointer(ref this), NewEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Item([NativeTypeName("long")] int Index, [NativeTypeName("IProgressItem **")] IProgressItem** item)
        {
            return ((delegate* unmanaged<IProgressItems*, int, IProgressItem**, int>)(lpVtbl[8]))((IProgressItems*)Unsafe.AsPointer(ref this), Index, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* unmanaged<IProgressItems*, int*, int>)(lpVtbl[9]))((IProgressItems*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProgressItemFromBlock([NativeTypeName("ULONG")] uint block, [NativeTypeName("IProgressItem **")] IProgressItem** item)
        {
            return ((delegate* unmanaged<IProgressItems*, uint, IProgressItem**, int>)(lpVtbl[10]))((IProgressItems*)Unsafe.AsPointer(ref this), block, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProgressItemFromDescription([NativeTypeName("BSTR")] ushort* description, [NativeTypeName("IProgressItem **")] IProgressItem** item)
        {
            return ((delegate* unmanaged<IProgressItems*, ushort*, IProgressItem**, int>)(lpVtbl[11]))((IProgressItems*)Unsafe.AsPointer(ref this), description, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EnumProgressItems([NativeTypeName("IEnumProgressItems **")] IEnumProgressItems** NewEnum)
        {
            return ((delegate* unmanaged<IProgressItems*, IEnumProgressItems**, int>)(lpVtbl[12]))((IProgressItems*)Unsafe.AsPointer(ref this), NewEnum);
        }
    }
}
