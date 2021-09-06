// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("57CED8A7-3F4A-432C-9350-30F24483F74F")]
    [NativeTypeName("struct INamespaceWalk : IUnknown")]
    public unsafe partial struct INamespaceWalk
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INamespaceWalk*, Guid*, void**, int>)(lpVtbl[0]))((INamespaceWalk*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INamespaceWalk*, uint>)(lpVtbl[1]))((INamespaceWalk*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INamespaceWalk*, uint>)(lpVtbl[2]))((INamespaceWalk*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Walk(IUnknown* punkToWalk, [NativeTypeName("DWORD")] uint dwFlags, int cDepth, INamespaceWalkCB* pnswcb)
        {
            return ((delegate* unmanaged<INamespaceWalk*, IUnknown*, uint, int, INamespaceWalkCB*, int>)(lpVtbl[3]))((INamespaceWalk*)Unsafe.AsPointer(ref this), punkToWalk, dwFlags, cDepth, pnswcb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDArrayResult([NativeTypeName("UINT *")] uint* pcItems, [NativeTypeName("LPITEMIDLIST **")] ITEMIDLIST*** prgpidl)
        {
            return ((delegate* unmanaged<INamespaceWalk*, uint*, ITEMIDLIST***, int>)(lpVtbl[4]))((INamespaceWalk*)Unsafe.AsPointer(ref this), pcItems, prgpidl);
        }
    }
}
