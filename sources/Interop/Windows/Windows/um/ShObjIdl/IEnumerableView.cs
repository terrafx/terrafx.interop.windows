// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("8C8BF236-1AEC-495F-9894-91D57C3C686F")]
    [NativeTypeName("struct IEnumerableView : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumerableView : IEnumerableView.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumerableView*, Guid*, void**, int>)(lpVtbl[0]))((IEnumerableView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumerableView*, uint>)(lpVtbl[1]))((IEnumerableView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumerableView*, uint>)(lpVtbl[2]))((IEnumerableView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetEnumReadyCallback(IEnumReadyCallback* percb)
        {
            return ((delegate* unmanaged<IEnumerableView*, IEnumReadyCallback*, int>)(lpVtbl[3]))((IEnumerableView*)Unsafe.AsPointer(ref this), percb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateEnumIDListFromContents([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("DWORD")] uint dwEnumFlags, IEnumIDList** ppEnumIDList)
        {
            return ((delegate* unmanaged<IEnumerableView*, ITEMIDLIST*, uint, IEnumIDList**, int>)(lpVtbl[4]))((IEnumerableView*)Unsafe.AsPointer(ref this), pidlFolder, dwEnumFlags, ppEnumIDList);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetEnumReadyCallback(IEnumReadyCallback* percb);

            [VtblIndex(4)]
            HRESULT CreateEnumIDListFromContents([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("DWORD")] uint dwEnumFlags, IEnumIDList** ppEnumIDList);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumerableView*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumerableView*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumerableView*, uint> Release;

            [NativeTypeName("HRESULT (IEnumReadyCallback *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumerableView*, IEnumReadyCallback*, int> SetEnumReadyCallback;

            [NativeTypeName("HRESULT (LPCITEMIDLIST, DWORD, IEnumIDList **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumerableView*, ITEMIDLIST*, uint, IEnumIDList**, int> CreateEnumIDListFromContents;
        }
    }
}
