// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1DB8392-7331-11D0-8C99-00A0C92DBFE8")]
    [NativeTypeName("struct IInputObjectSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInputObjectSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInputObjectSite*, Guid*, void**, int>)(lpVtbl[0]))((IInputObjectSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInputObjectSite*, uint>)(lpVtbl[1]))((IInputObjectSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInputObjectSite*, uint>)(lpVtbl[2]))((IInputObjectSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnFocusChangeIS(IUnknown* punkObj, BOOL fSetFocus)
        {
            return ((delegate* unmanaged<IInputObjectSite*, IUnknown*, BOOL, int>)(lpVtbl[3]))((IInputObjectSite*)Unsafe.AsPointer(ref this), punkObj, fSetFocus);
        }
    }
}
