// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("842B32A3-9B9B-4D1C-B3F3-49193248A554")]
    [NativeTypeName("struct IPlayToSourceClassFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPlayToSourceClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPlayToSourceClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPlayToSourceClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPlayToSourceClassFactory*, uint>)(lpVtbl[1]))((IPlayToSourceClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPlayToSourceClassFactory*, uint>)(lpVtbl[2]))((IPlayToSourceClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IPlayToControl* pControl, IInspectable** ppSource)
        {
            return ((delegate* unmanaged<IPlayToSourceClassFactory*, uint, IPlayToControl*, IInspectable**, int>)(lpVtbl[3]))((IPlayToSourceClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pControl, ppSource);
        }
    }
}
