// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B013E6-2811-4845-BAA7-D623FE0DF104")]
    [NativeTypeName("struct ID3D11ShaderTrace : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11ShaderTrace
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, uint>)(lpVtbl[1]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, uint>)(lpVtbl[2]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int TraceReady([NativeTypeName("UINT64 *")] ulong* pTestCount)
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, ulong*, int>)(lpVtbl[3]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTestCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void ResetTrace()
        {
            ((delegate* unmanaged<ID3D11ShaderTrace*, void>)(lpVtbl[4]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetTraceStats(D3D11_TRACE_STATS* pTraceStats)
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, D3D11_TRACE_STATS*, int>)(lpVtbl[5]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTraceStats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int PSSelectStamp([NativeTypeName("UINT")] uint stampIndex)
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, uint, int>)(lpVtbl[6]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stampIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetInitialRegisterContents(D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue)
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int>)(lpVtbl[7]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pRegister, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetStep([NativeTypeName("UINT")] uint stepIndex, D3D11_TRACE_STEP* pTraceStep)
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, uint, D3D11_TRACE_STEP*, int>)(lpVtbl[8]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, pTraceStep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetWrittenRegister([NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("UINT")] uint writtenRegisterIndex, D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue)
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int>)(lpVtbl[9]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, writtenRegisterIndex, pRegister, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetReadRegister([NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("UINT")] uint readRegisterIndex, D3D11_TRACE_REGISTER* pRegister, D3D11_TRACE_VALUE* pValue)
        {
            return ((delegate* unmanaged<ID3D11ShaderTrace*, uint, uint, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int>)(lpVtbl[10]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, readRegisterIndex, pRegister, pValue);
        }
    }
}
