// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("997706EF-F880-453B-8118-39E1A2D2655A")]
    [NativeTypeName("struct IHandlerInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHandlerInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHandlerInfo*, Guid*, void**, int>)(lpVtbl[0]))((IHandlerInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHandlerInfo*, uint>)(lpVtbl[1]))((IHandlerInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHandlerInfo*, uint>)(lpVtbl[2]))((IHandlerInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetApplicationDisplayName([NativeTypeName("LPWSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IHandlerInfo*, ushort**, int>)(lpVtbl[3]))((IHandlerInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetApplicationPublisher([NativeTypeName("LPWSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IHandlerInfo*, ushort**, int>)(lpVtbl[4]))((IHandlerInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetApplicationIconReference([NativeTypeName("LPWSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IHandlerInfo*, ushort**, int>)(lpVtbl[5]))((IHandlerInfo*)Unsafe.AsPointer(ref this), value);
        }
    }
}
