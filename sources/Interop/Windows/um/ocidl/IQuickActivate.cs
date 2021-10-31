// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF51ED10-62FE-11CF-BF86-00A0C9034836")]
    [NativeTypeName("struct IQuickActivate : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IQuickActivate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IQuickActivate*, Guid*, void**, int>)(lpVtbl[0]))((IQuickActivate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQuickActivate*, uint>)(lpVtbl[1]))((IQuickActivate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQuickActivate*, uint>)(lpVtbl[2]))((IQuickActivate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QuickActivate(QACONTAINER* pQaContainer, QACONTROL* pQaControl)
        {
            return ((delegate* unmanaged<IQuickActivate*, QACONTAINER*, QACONTROL*, int>)(lpVtbl[3]))((IQuickActivate*)Unsafe.AsPointer(ref this), pQaContainer, pQaControl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return ((delegate* unmanaged<IQuickActivate*, SIZE*, int>)(lpVtbl[4]))((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return ((delegate* unmanaged<IQuickActivate*, SIZE*, int>)(lpVtbl[5]))((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
        }
    }
}
