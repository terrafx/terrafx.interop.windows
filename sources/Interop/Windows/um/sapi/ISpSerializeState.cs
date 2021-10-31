// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("21B501A0-0EC7-46C9-92C3-A2BC784C54B9")]
    [NativeTypeName("struct ISpSerializeState : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpSerializeState
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpSerializeState*, Guid*, void**, int>)(lpVtbl[0]))((ISpSerializeState*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpSerializeState*, uint>)(lpVtbl[1]))((ISpSerializeState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpSerializeState*, uint>)(lpVtbl[2]))((ISpSerializeState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSerializedState(byte** ppbData, [NativeTypeName("ULONG *")] uint* pulSize, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISpSerializeState*, byte**, uint*, uint, int>)(lpVtbl[3]))((ISpSerializeState*)Unsafe.AsPointer(ref this), ppbData, pulSize, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetSerializedState(byte* pbData, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISpSerializeState*, byte*, uint, uint, int>)(lpVtbl[4]))((ISpSerializeState*)Unsafe.AsPointer(ref this), pbData, ulSize, dwReserved);
        }
    }
}
