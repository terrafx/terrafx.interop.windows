// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B013E6-2811-4845-BAA7-D623FE0DF104")]
    public unsafe partial struct ID3D11ShaderTrace
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TraceReady([NativeTypeName("UINT64 *")] ulong* pTestCount)
        {
            return lpVtbl->TraceReady((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTestCount);
        }

        public void ResetTrace()
        {
            lpVtbl->ResetTrace((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTraceStats([NativeTypeName("D3D11_TRACE_STATS *")] D3D11_TRACE_STATS* pTraceStats)
        {
            return lpVtbl->GetTraceStats((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTraceStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int PSSelectStamp([NativeTypeName("UINT")] uint stampIndex)
        {
            return lpVtbl->PSSelectStamp((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stampIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInitialRegisterContents([NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue)
        {
            return lpVtbl->GetInitialRegisterContents((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pRegister, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStep([NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("D3D11_TRACE_STEP *")] D3D11_TRACE_STEP* pTraceStep)
        {
            return lpVtbl->GetStep((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, pTraceStep);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWrittenRegister([NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("UINT")] uint writtenRegisterIndex, [NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue)
        {
            return lpVtbl->GetWrittenRegister((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, writtenRegisterIndex, pRegister, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReadRegister([NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("UINT")] uint readRegisterIndex, [NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue)
        {
            return lpVtbl->GetReadRegister((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, readRegisterIndex, pRegister, pValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, uint> Release;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, ulong*, int> TraceReady;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, void> ResetTrace;

            [NativeTypeName("HRESULT (D3D11_TRACE_STATS *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, D3D11_TRACE_STATS*, int> GetTraceStats;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, uint, int> PSSelectStamp;

            [NativeTypeName("HRESULT (D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> GetInitialRegisterContents;

            [NativeTypeName("HRESULT (UINT, D3D11_TRACE_STEP *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, uint, D3D11_TRACE_STEP*, int> GetStep;

            [NativeTypeName("HRESULT (UINT, UINT, D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, uint, uint, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> GetWrittenRegister;

            [NativeTypeName("HRESULT (UINT, UINT, D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTrace*, uint, uint, D3D11_TRACE_REGISTER*, D3D11_TRACE_VALUE*, int> GetReadRegister;
        }
    }
}
