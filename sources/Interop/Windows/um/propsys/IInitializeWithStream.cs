// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B824B49D-22AC-4161-AC8A-9916E8FA3F7F")]
    [NativeTypeName("struct IInitializeWithStream : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInitializeWithStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInitializeWithStream*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeWithStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInitializeWithStream*, uint>)(lpVtbl[1]))((IInitializeWithStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInitializeWithStream*, uint>)(lpVtbl[2]))((IInitializeWithStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize(IStream* pstream, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* unmanaged<IInitializeWithStream*, IStream*, uint, int>)(lpVtbl[3]))((IInitializeWithStream*)Unsafe.AsPointer(ref this), pstream, grfMode);
        }
    }
}
