// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F425-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementBehavior : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementBehavior
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementBehavior*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementBehavior*, uint>)(lpVtbl[1]))((IElementBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementBehavior*, uint>)(lpVtbl[2]))((IElementBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Init(IElementBehaviorSite* pBehaviorSite)
        {
            return ((delegate* unmanaged<IElementBehavior*, IElementBehaviorSite*, int>)(lpVtbl[3]))((IElementBehavior*)Unsafe.AsPointer(ref this), pBehaviorSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Notify([NativeTypeName("LONG")] int lEvent, VARIANT* pVar)
        {
            return ((delegate* unmanaged<IElementBehavior*, int, VARIANT*, int>)(lpVtbl[4]))((IElementBehavior*)Unsafe.AsPointer(ref this), lEvent, pVar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Detach()
        {
            return ((delegate* unmanaged<IElementBehavior*, int>)(lpVtbl[5]))((IElementBehavior*)Unsafe.AsPointer(ref this));
        }
    }
}
