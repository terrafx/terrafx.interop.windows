// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87D605E0-C511-11CF-89A9-00A0C9054129")]
    [NativeTypeName("struct IDocViewSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDocViewSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDocViewSite*, Guid*, void**, int>)(lpVtbl[0]))((IDocViewSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDocViewSite*, uint>)(lpVtbl[1]))((IDocViewSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDocViewSite*, uint>)(lpVtbl[2]))((IDocViewSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetTitle([NativeTypeName("VARIANTARG *")] VARIANT* pvTitle)
        {
            return ((delegate* unmanaged<IDocViewSite*, VARIANT*, int>)(lpVtbl[3]))((IDocViewSite*)Unsafe.AsPointer(ref this), pvTitle);
        }
    }
}
