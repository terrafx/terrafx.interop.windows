// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("CAC701EE-80FC-4122-8242-10B39C8CEC34")]
    [NativeTypeName("struct ID3D11Module : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11Module : ID3D11Module.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Module*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Module*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Module*, uint>)(lpVtbl[1]))((ID3D11Module*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Module*, uint>)(lpVtbl[2]))((ID3D11Module*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateInstance([NativeTypeName("LPCSTR")] sbyte* pNamespace, [NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance)
        {
            return ((delegate* unmanaged<ID3D11Module*, sbyte*, ID3D11ModuleInstance**, int>)(lpVtbl[3]))((ID3D11Module*)Unsafe.AsPointer(ref this), pNamespace, ppModuleInstance);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateInstance([NativeTypeName("LPCSTR")] sbyte* pNamespace, [NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Module*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Module*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Module*, uint> Release;

            [NativeTypeName("HRESULT (LPCSTR, struct ID3D11ModuleInstance **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Module*, sbyte*, ID3D11ModuleInstance**, int> CreateInstance;
        }
    }
}
