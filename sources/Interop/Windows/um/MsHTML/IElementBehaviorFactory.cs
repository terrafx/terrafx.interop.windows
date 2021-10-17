// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F429-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementBehaviorFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementBehaviorFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementBehaviorFactory*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementBehaviorFactory*, uint>)(lpVtbl[1]))((IElementBehaviorFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementBehaviorFactory*, uint>)(lpVtbl[2]))((IElementBehaviorFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int FindBehavior([NativeTypeName("BSTR")] ushort* bstrBehavior, [NativeTypeName("BSTR")] ushort* bstrBehaviorUrl, IElementBehaviorSite* pSite, IElementBehavior** ppBehavior)
        {
            return ((delegate* unmanaged<IElementBehaviorFactory*, ushort*, ushort*, IElementBehaviorSite*, IElementBehavior**, int>)(lpVtbl[3]))((IElementBehaviorFactory*)Unsafe.AsPointer(ref this), bstrBehavior, bstrBehaviorUrl, pSite, ppBehavior);
        }
    }
}
