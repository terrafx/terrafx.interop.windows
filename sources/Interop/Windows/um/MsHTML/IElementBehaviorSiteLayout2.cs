// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F847-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementBehaviorSiteLayout2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementBehaviorSiteLayout2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteLayout2*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorSiteLayout2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementBehaviorSiteLayout2*, uint>)(lpVtbl[1]))((IElementBehaviorSiteLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementBehaviorSiteLayout2*, uint>)(lpVtbl[2]))((IElementBehaviorSiteLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontInfo(LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IElementBehaviorSiteLayout2*, LOGFONTW*, int>)(lpVtbl[3]))((IElementBehaviorSiteLayout2*)Unsafe.AsPointer(ref this), plf);
        }
    }
}
