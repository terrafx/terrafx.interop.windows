// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0DF60D92-6818-46D6-B358-D66170DDE466")]
    [NativeTypeName("struct IComputerInfoChangeNotify : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IComputerInfoChangeNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IComputerInfoChangeNotify*, Guid*, void**, int>)(lpVtbl[0]))((IComputerInfoChangeNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IComputerInfoChangeNotify*, uint>)(lpVtbl[1]))((IComputerInfoChangeNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IComputerInfoChangeNotify*, uint>)(lpVtbl[2]))((IComputerInfoChangeNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ComputerInfoChanged()
        {
            return ((delegate* unmanaged<IComputerInfoChangeNotify*, int>)(lpVtbl[3]))((IComputerInfoChangeNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
