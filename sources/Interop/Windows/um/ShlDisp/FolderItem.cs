// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FAC32C80-CBE4-11CE-8350-444553540000")]
    [NativeTypeName("struct FolderItem : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct FolderItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<FolderItem*, Guid*, void**, int>)(lpVtbl[0]))((FolderItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<FolderItem*, uint>)(lpVtbl[1]))((FolderItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<FolderItem*, uint>)(lpVtbl[2]))((FolderItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<FolderItem*, uint*, int>)(lpVtbl[3]))((FolderItem*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<FolderItem*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((FolderItem*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<FolderItem*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((FolderItem*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<FolderItem*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((FolderItem*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<FolderItem*, IDispatch**, int>)(lpVtbl[7]))((FolderItem*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<FolderItem*, IDispatch**, int>)(lpVtbl[8]))((FolderItem*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<FolderItem*, ushort**, int>)(lpVtbl[9]))((FolderItem*)Unsafe.AsPointer(ref this), pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_Name([NativeTypeName("BSTR")] ushort* bs)
        {
            return ((delegate* unmanaged<FolderItem*, ushort*, int>)(lpVtbl[10]))((FolderItem*)Unsafe.AsPointer(ref this), bs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<FolderItem*, ushort**, int>)(lpVtbl[11]))((FolderItem*)Unsafe.AsPointer(ref this), pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_GetLink(IDispatch** ppid)
        {
            return ((delegate* unmanaged<FolderItem*, IDispatch**, int>)(lpVtbl[12]))((FolderItem*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_GetFolder(IDispatch** ppid)
        {
            return ((delegate* unmanaged<FolderItem*, IDispatch**, int>)(lpVtbl[13]))((FolderItem*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_IsLink([NativeTypeName("VARIANT_BOOL *")] short* pb)
        {
            return ((delegate* unmanaged<FolderItem*, short*, int>)(lpVtbl[14]))((FolderItem*)Unsafe.AsPointer(ref this), pb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_IsFolder([NativeTypeName("VARIANT_BOOL *")] short* pb)
        {
            return ((delegate* unmanaged<FolderItem*, short*, int>)(lpVtbl[15]))((FolderItem*)Unsafe.AsPointer(ref this), pb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_IsFileSystem([NativeTypeName("VARIANT_BOOL *")] short* pb)
        {
            return ((delegate* unmanaged<FolderItem*, short*, int>)(lpVtbl[16]))((FolderItem*)Unsafe.AsPointer(ref this), pb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_IsBrowsable([NativeTypeName("VARIANT_BOOL *")] short* pb)
        {
            return ((delegate* unmanaged<FolderItem*, short*, int>)(lpVtbl[17]))((FolderItem*)Unsafe.AsPointer(ref this), pb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_ModifyDate([NativeTypeName("DATE *")] double* pdt)
        {
            return ((delegate* unmanaged<FolderItem*, double*, int>)(lpVtbl[18]))((FolderItem*)Unsafe.AsPointer(ref this), pdt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_ModifyDate([NativeTypeName("DATE")] double dt)
        {
            return ((delegate* unmanaged<FolderItem*, double, int>)(lpVtbl[19]))((FolderItem*)Unsafe.AsPointer(ref this), dt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_Size([NativeTypeName("LONG *")] int* pul)
        {
            return ((delegate* unmanaged<FolderItem*, int*, int>)(lpVtbl[20]))((FolderItem*)Unsafe.AsPointer(ref this), pul);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<FolderItem*, ushort**, int>)(lpVtbl[21]))((FolderItem*)Unsafe.AsPointer(ref this), pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT Verbs(FolderItemVerbs** ppfic)
        {
            return ((delegate* unmanaged<FolderItem*, FolderItemVerbs**, int>)(lpVtbl[22]))((FolderItem*)Unsafe.AsPointer(ref this), ppfic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT InvokeVerb(VARIANT vVerb)
        {
            return ((delegate* unmanaged<FolderItem*, VARIANT, int>)(lpVtbl[23]))((FolderItem*)Unsafe.AsPointer(ref this), vVerb);
        }
    }
}
