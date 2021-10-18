// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F646-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementBehaviorSubmit : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementBehaviorSubmit
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSubmit*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementBehaviorSubmit*, uint>)(lpVtbl[1]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementBehaviorSubmit*, uint>)(lpVtbl[2]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubmitInfo(IHTMLSubmitData* pSubmitData)
        {
            return ((delegate* unmanaged<IElementBehaviorSubmit*, IHTMLSubmitData*, int>)(lpVtbl[3]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this), pSubmitData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IElementBehaviorSubmit*, int>)(lpVtbl[4]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this));
        }
    }
}
