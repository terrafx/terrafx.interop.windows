// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6087428-3BE3-4D73-B308-7C04A540BF1A")]
    [NativeTypeName("struct IObjectProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IObjectProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectProvider*, Guid*, void**, int>)(lpVtbl[0]))((IObjectProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectProvider*, uint>)(lpVtbl[1]))((IObjectProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectProvider*, uint>)(lpVtbl[2]))((IObjectProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryObject([NativeTypeName("const GUID &")] Guid* guidObject, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut)
        {
            return ((delegate* unmanaged<IObjectProvider*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IObjectProvider*)Unsafe.AsPointer(ref this), guidObject, riid, ppvOut);
        }
    }
}
