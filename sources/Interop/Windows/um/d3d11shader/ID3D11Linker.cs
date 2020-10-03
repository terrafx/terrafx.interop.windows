// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("59A6CD0E-E10D-4C1F-88C0-63ABA1DAF30E")]
    [NativeTypeName("struct ID3D11Linker : IUnknown")]
    public unsafe partial struct ID3D11Linker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Linker*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Linker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Linker*, uint>)(lpVtbl[1]))((ID3D11Linker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Linker*, uint>)(lpVtbl[2]))((ID3D11Linker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Link([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pEntry, [NativeTypeName("LPCSTR")] sbyte* pEntryName, [NativeTypeName("LPCSTR")] sbyte* pTargetName, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppShaderBlob, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBuffer)
        {
            return ((delegate* unmanaged<ID3D11Linker*, ID3D11ModuleInstance*, sbyte*, sbyte*, uint, ID3DBlob**, ID3DBlob**, int>)(lpVtbl[3]))((ID3D11Linker*)Unsafe.AsPointer(ref this), pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UseLibrary([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pLibraryMI)
        {
            return ((delegate* unmanaged<ID3D11Linker*, ID3D11ModuleInstance*, int>)(lpVtbl[4]))((ID3D11Linker*)Unsafe.AsPointer(ref this), pLibraryMI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddClipPlaneFromCBuffer([NativeTypeName("UINT")] uint uCBufferSlot, [NativeTypeName("UINT")] uint uCBufferEntry)
        {
            return ((delegate* unmanaged<ID3D11Linker*, uint, uint, int>)(lpVtbl[5]))((ID3D11Linker*)Unsafe.AsPointer(ref this), uCBufferSlot, uCBufferEntry);
        }
    }
}
