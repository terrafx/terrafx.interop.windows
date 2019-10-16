// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B013E6-2811-4845-BAA7-D623FE0DF104")]
    public unsafe partial struct ID3D11ShaderTrace
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11ShaderTrace* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11ShaderTrace* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11ShaderTrace* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TraceReady(ID3D11ShaderTrace* pThis, [NativeTypeName("UINT64 *")] ulong* pTestCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ResetTrace(ID3D11ShaderTrace* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTraceStats(ID3D11ShaderTrace* pThis, [NativeTypeName("D3D11_TRACE_STATS *")] D3D11_TRACE_STATS* pTraceStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PSSelectStamp(ID3D11ShaderTrace* pThis, [NativeTypeName("UINT")] uint stampIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetInitialRegisterContents(ID3D11ShaderTrace* pThis, [NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStep(ID3D11ShaderTrace* pThis, [NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("D3D11_TRACE_STEP *")] D3D11_TRACE_STEP* pTraceStep);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWrittenRegister(ID3D11ShaderTrace* pThis, [NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("UINT")] uint writtenRegisterIndex, [NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetReadRegister(ID3D11ShaderTrace* pThis, [NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("UINT")] uint readRegisterIndex, [NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TraceReady([NativeTypeName("UINT64 *")] ulong* pTestCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_TraceReady>(lpVtbl->TraceReady)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTestCount);
        }

        public void ResetTrace()
        {
            Marshal.GetDelegateForFunctionPointer<_ResetTrace>(lpVtbl->ResetTrace)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTraceStats([NativeTypeName("D3D11_TRACE_STATS *")] D3D11_TRACE_STATS* pTraceStats)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTraceStats>(lpVtbl->GetTraceStats)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTraceStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int PSSelectStamp([NativeTypeName("UINT")] uint stampIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_PSSelectStamp>(lpVtbl->PSSelectStamp)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stampIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInitialRegisterContents([NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInitialRegisterContents>(lpVtbl->GetInitialRegisterContents)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pRegister, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStep([NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("D3D11_TRACE_STEP *")] D3D11_TRACE_STEP* pTraceStep)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStep>(lpVtbl->GetStep)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, pTraceStep);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWrittenRegister([NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("UINT")] uint writtenRegisterIndex, [NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWrittenRegister>(lpVtbl->GetWrittenRegister)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, writtenRegisterIndex, pRegister, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReadRegister([NativeTypeName("UINT")] uint stepIndex, [NativeTypeName("UINT")] uint readRegisterIndex, [NativeTypeName("D3D11_TRACE_REGISTER *")] D3D11_TRACE_REGISTER* pRegister, [NativeTypeName("D3D11_TRACE_VALUE *")] D3D11_TRACE_VALUE* pValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetReadRegister>(lpVtbl->GetReadRegister)((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, readRegisterIndex, pRegister, pValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
            public IntPtr TraceReady;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr ResetTrace;

            [NativeTypeName("HRESULT (D3D11_TRACE_STATS *) __attribute__((stdcall))")]
            public IntPtr GetTraceStats;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr PSSelectStamp;

            [NativeTypeName("HRESULT (D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
            public IntPtr GetInitialRegisterContents;

            [NativeTypeName("HRESULT (UINT, D3D11_TRACE_STEP *) __attribute__((stdcall))")]
            public IntPtr GetStep;

            [NativeTypeName("HRESULT (UINT, UINT, D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
            public IntPtr GetWrittenRegister;

            [NativeTypeName("HRESULT (UINT, UINT, D3D11_TRACE_REGISTER *, D3D11_TRACE_VALUE *) __attribute__((stdcall))")]
            public IntPtr GetReadRegister;
        }
    }
}
