// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("842B32A3-9B9B-4D1C-B3F3-49193248A554")]
    [NativeTypeName("struct IPlayToSourceClassFactory : IUnknown")]
    public unsafe partial struct IPlayToSourceClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPlayToSourceClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPlayToSourceClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPlayToSourceClassFactory*, uint>)(lpVtbl[1]))((IPlayToSourceClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPlayToSourceClassFactory*, uint>)(lpVtbl[2]))((IPlayToSourceClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IPlayToControl *")] IPlayToControl* pControl, [NativeTypeName("IInspectable **")] IInspectable** ppSource)
        {
            return ((delegate* unmanaged[Stdcall]<IPlayToSourceClassFactory*, uint, IPlayToControl*, IInspectable**, int>)(lpVtbl[3]))((IPlayToSourceClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pControl, ppSource);
        }
    }
}
