// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("67EFED0E-E827-4408-B493-78F3982B685C")]
    [NativeTypeName("struct IParseAndCreateItem : IUnknown")]
    public unsafe partial struct IParseAndCreateItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IParseAndCreateItem*, Guid*, void**, int>)(lpVtbl[0]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IParseAndCreateItem*, uint>)(lpVtbl[1]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IParseAndCreateItem*, uint>)(lpVtbl[2]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItem(IShellItem* psi)
        {
            return ((delegate* unmanaged<IParseAndCreateItem*, IShellItem*, int>)(lpVtbl[3]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IParseAndCreateItem*, Guid*, void**, int>)(lpVtbl[4]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
