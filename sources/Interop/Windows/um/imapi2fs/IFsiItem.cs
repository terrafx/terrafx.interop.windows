// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C941FD9-975B-59BE-A960-9A2A262853A5")]
    [NativeTypeName("struct IFsiItem : IDispatch")]
    public unsafe partial struct IFsiItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFsiItem*, Guid*, void**, int>)(lpVtbl[0]))((IFsiItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFsiItem*, uint>)(lpVtbl[1]))((IFsiItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFsiItem*, uint>)(lpVtbl[2]))((IFsiItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFsiItem*, uint*, int>)(lpVtbl[3]))((IFsiItem*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFsiItem*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFsiItem*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFsiItem*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFsiItem*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFsiItem*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFsiItem*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiItem*, ushort**, int>)(lpVtbl[7]))((IFsiItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FullPath([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiItem*, ushort**, int>)(lpVtbl[8]))((IFsiItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CreationTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiItem*, double*, int>)(lpVtbl[9]))((IFsiItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CreationTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiItem*, double, int>)(lpVtbl[10]))((IFsiItem*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastAccessedTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiItem*, double*, int>)(lpVtbl[11]))((IFsiItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_LastAccessedTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiItem*, double, int>)(lpVtbl[12]))((IFsiItem*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastModifiedTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiItem*, double*, int>)(lpVtbl[13]))((IFsiItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_LastModifiedTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiItem*, double, int>)(lpVtbl[14]))((IFsiItem*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsHidden([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFsiItem*, short*, int>)(lpVtbl[15]))((IFsiItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsHidden([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFsiItem*, short, int>)(lpVtbl[16]))((IFsiItem*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FileSystemName(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiItem*, FsiFileSystems, ushort**, int>)(lpVtbl[17]))((IFsiItem*)Unsafe.AsPointer(ref this), fileSystem, pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FileSystemPath(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiItem*, FsiFileSystems, ushort**, int>)(lpVtbl[18]))((IFsiItem*)Unsafe.AsPointer(ref this), fileSystem, pVal);
        }
    }
}
