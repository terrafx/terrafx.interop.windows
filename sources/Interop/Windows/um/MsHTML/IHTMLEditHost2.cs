// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F848-98B5-11CF-BB82-00AA00BDCE0D")]
    [NativeTypeName("struct IHTMLEditHost2 : IHTMLEditHost")]
    [NativeInheritance("IHTMLEditHost")]
    public unsafe partial struct IHTMLEditHost2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLEditHost2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLEditHost2*, uint>)(lpVtbl[1]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLEditHost2*, uint>)(lpVtbl[2]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SnapRect(IHTMLElement* pIElement, RECT* prcNew, ELEMENT_CORNER eHandle)
        {
            return ((delegate* unmanaged<IHTMLEditHost2*, IHTMLElement*, RECT*, ELEMENT_CORNER, int>)(lpVtbl[3]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this), pIElement, prcNew, eHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int PreDrag()
        {
            return ((delegate* unmanaged<IHTMLEditHost2*, int>)(lpVtbl[4]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this));
        }
    }
}
