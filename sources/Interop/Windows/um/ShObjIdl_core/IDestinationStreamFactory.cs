// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8A87781B-39A7-4A1F-AAB3-A39B9C34A7D9")]
    [NativeTypeName("struct IDestinationStreamFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDestinationStreamFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDestinationStreamFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDestinationStreamFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDestinationStreamFactory*, uint>)(lpVtbl[1]))((IDestinationStreamFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDestinationStreamFactory*, uint>)(lpVtbl[2]))((IDestinationStreamFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestinationStream(IStream** ppstm)
        {
            return ((delegate* unmanaged<IDestinationStreamFactory*, IStream**, int>)(lpVtbl[3]))((IDestinationStreamFactory*)Unsafe.AsPointer(ref this), ppstm);
        }
    }
}
