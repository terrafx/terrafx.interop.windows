// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("84AC29BB-D619-44D2-B197-E4ACF7DF3ED6")]
    public unsafe partial struct IXAudio2Extension
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXAudio2Extension* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXAudio2Extension* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXAudio2Extension* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetProcessingQuantum(IXAudio2Extension* pThis, [NativeTypeName("UINT32 *")] uint* quantumNumerator, [NativeTypeName("UINT32 *")] uint* quantumDenominator);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetProcessor(IXAudio2Extension* pThis, [NativeTypeName("XAUDIO2_PROCESSOR *")] uint* processor);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXAudio2Extension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXAudio2Extension*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXAudio2Extension*)Unsafe.AsPointer(ref this));
        }

        public void GetProcessingQuantum([NativeTypeName("UINT32 *")] uint* quantumNumerator, [NativeTypeName("UINT32 *")] uint* quantumDenominator)
        {
            Marshal.GetDelegateForFunctionPointer<_GetProcessingQuantum>(lpVtbl->GetProcessingQuantum)((IXAudio2Extension*)Unsafe.AsPointer(ref this), quantumNumerator, quantumDenominator);
        }

        public void GetProcessor([NativeTypeName("XAUDIO2_PROCESSOR *")] uint* processor)
        {
            Marshal.GetDelegateForFunctionPointer<_GetProcessor>(lpVtbl->GetProcessor)((IXAudio2Extension*)Unsafe.AsPointer(ref this), processor);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (UINT32 *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetProcessingQuantum;

            [NativeTypeName("void (XAUDIO2_PROCESSOR *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetProcessor;
        }
    }
}
