// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF51ED10-62FE-11CF-BF86-00A0C9034836")]
    [NativeTypeName("struct IQuickActivate : IUnknown")]
    public unsafe partial struct IQuickActivate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IQuickActivate*, Guid*, void**, int>)(lpVtbl[0]))((IQuickActivate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IQuickActivate*, uint>)(lpVtbl[1]))((IQuickActivate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IQuickActivate*, uint>)(lpVtbl[2]))((IQuickActivate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QuickActivate([NativeTypeName("QACONTAINER *")] QACONTAINER* pQaContainer, [NativeTypeName("QACONTROL *")] QACONTROL* pQaControl)
        {
            return ((delegate* stdcall<IQuickActivate*, QACONTAINER*, QACONTROL*, int>)(lpVtbl[3]))((IQuickActivate*)Unsafe.AsPointer(ref this), pQaContainer, pQaControl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return ((delegate* stdcall<IQuickActivate*, SIZE*, int>)(lpVtbl[4]))((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return ((delegate* stdcall<IQuickActivate*, SIZE*, int>)(lpVtbl[5]))((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
        }
    }
}
