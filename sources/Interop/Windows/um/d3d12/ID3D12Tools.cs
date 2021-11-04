// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7071E1F0-E84B-4B33-974F-12FA49DE65C5")]
    [NativeTypeName("struct ID3D12Tools : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D12Tools : ID3D12Tools.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Tools*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Tools*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Tools*, uint>)(lpVtbl[1]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12Tools*, uint>)(lpVtbl[2]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void EnableShaderInstrumentation(BOOL bEnable)
        {
            ((delegate* unmanaged<ID3D12Tools*, BOOL, void>)(lpVtbl[3]))((ID3D12Tools*)Unsafe.AsPointer(ref this), bEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public BOOL ShaderInstrumentationEnabled()
        {
            return ((delegate* unmanaged<ID3D12Tools*, int>)(lpVtbl[4]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            void EnableShaderInstrumentation(BOOL bEnable);

            [VtblIndex(4)]
            BOOL ShaderInstrumentationEnabled();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12Tools*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12Tools*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12Tools*, uint> Release;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12Tools*, BOOL, void> EnableShaderInstrumentation;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12Tools*, int> ShaderInstrumentationEnabled;
        }
    }
}
