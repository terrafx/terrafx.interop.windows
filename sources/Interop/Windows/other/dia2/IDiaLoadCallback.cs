// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C32ADB82-73F4-421B-95D5-A4706EDF5DBE")]
    [NativeTypeName("struct IDiaLoadCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaLoadCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaLoadCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDiaLoadCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaLoadCallback*, uint>)(lpVtbl[1]))((IDiaLoadCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaLoadCallback*, uint>)(lpVtbl[2]))((IDiaLoadCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyDebugDir([NativeTypeName("BOOL")] int fExecutable, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BYTE *")] byte* pbData)
        {
            return ((delegate* unmanaged<IDiaLoadCallback*, int, uint, byte*, int>)(lpVtbl[3]))((IDiaLoadCallback*)Unsafe.AsPointer(ref this), fExecutable, cbData, pbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyOpenDBG([NativeTypeName("LPCOLESTR")] ushort* dbgPath, [NativeTypeName("HRESULT")] int resultCode)
        {
            return ((delegate* unmanaged<IDiaLoadCallback*, ushort*, int, int>)(lpVtbl[4]))((IDiaLoadCallback*)Unsafe.AsPointer(ref this), dbgPath, resultCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyOpenPDB([NativeTypeName("LPCOLESTR")] ushort* pdbPath, [NativeTypeName("HRESULT")] int resultCode)
        {
            return ((delegate* unmanaged<IDiaLoadCallback*, ushort*, int, int>)(lpVtbl[5]))((IDiaLoadCallback*)Unsafe.AsPointer(ref this), pdbPath, resultCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int RestrictRegistryAccess()
        {
            return ((delegate* unmanaged<IDiaLoadCallback*, int>)(lpVtbl[6]))((IDiaLoadCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int RestrictSymbolServerAccess()
        {
            return ((delegate* unmanaged<IDiaLoadCallback*, int>)(lpVtbl[7]))((IDiaLoadCallback*)Unsafe.AsPointer(ref this));
        }
    }
}
