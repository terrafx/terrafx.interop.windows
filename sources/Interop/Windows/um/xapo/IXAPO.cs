// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A410B984-9839-4819-A0BE-2856AE6B3ADB")]
    public unsafe partial struct IXAPO
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXAPO* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXAPO* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXAPO* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRegistrationProperties(IXAPO* pThis, [NativeTypeName("XAPO_REGISTRATION_PROPERTIES **")] XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsInputFormatSupported(IXAPO* pThis, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pOutputFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedInputFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppSupportedInputFormat);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsOutputFormatSupported(IXAPO* pThis, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pInputFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedOutputFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppSupportedOutputFormat);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(IXAPO* pThis, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT32")] uint DataByteSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Reset(IXAPO* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockForProcess(IXAPO* pThis, [NativeTypeName("UINT32")] uint InputLockedParameterCount, [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")] XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pInputLockedParameters, [NativeTypeName("UINT32")] uint OutputLockedParameterCount, [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")] XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pOutputLockedParameters);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _UnlockForProcess(IXAPO* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Process(IXAPO* pThis, [NativeTypeName("UINT32")] uint InputProcessParameterCount, [NativeTypeName("const XAPO_PROCESS_BUFFER_PARAMETERS *")] XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters, [NativeTypeName("UINT32")] uint OutputProcessParameterCount, [NativeTypeName("XAPO_PROCESS_BUFFER_PARAMETERS *")] XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters, [NativeTypeName("BOOL")] int IsEnabled);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _CalcInputFrames(IXAPO* pThis, [NativeTypeName("UINT32")] uint OutputFrameCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _CalcOutputFrames(IXAPO* pThis, [NativeTypeName("UINT32")] uint InputFrameCount);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXAPO*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRegistrationProperties([NativeTypeName("XAPO_REGISTRATION_PROPERTIES **")] XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRegistrationProperties>(lpVtbl->GetRegistrationProperties)((IXAPO*)Unsafe.AsPointer(ref this), ppRegistrationProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsInputFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pOutputFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedInputFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppSupportedInputFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsInputFormatSupported>(lpVtbl->IsInputFormatSupported)((IXAPO*)Unsafe.AsPointer(ref this), pOutputFormat, pRequestedInputFormat, ppSupportedInputFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsOutputFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pInputFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedOutputFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppSupportedOutputFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsOutputFormatSupported>(lpVtbl->IsOutputFormatSupported)((IXAPO*)Unsafe.AsPointer(ref this), pInputFormat, pRequestedOutputFormat, ppSupportedOutputFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT32")] uint DataByteSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)((IXAPO*)Unsafe.AsPointer(ref this), pData, DataByteSize);
        }

        public void Reset()
        {
            Marshal.GetDelegateForFunctionPointer<_Reset>(lpVtbl->Reset)((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockForProcess([NativeTypeName("UINT32")] uint InputLockedParameterCount, [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")] XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pInputLockedParameters, [NativeTypeName("UINT32")] uint OutputLockedParameterCount, [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")] XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pOutputLockedParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockForProcess>(lpVtbl->LockForProcess)((IXAPO*)Unsafe.AsPointer(ref this), InputLockedParameterCount, pInputLockedParameters, OutputLockedParameterCount, pOutputLockedParameters);
        }

        public void UnlockForProcess()
        {
            Marshal.GetDelegateForFunctionPointer<_UnlockForProcess>(lpVtbl->UnlockForProcess)((IXAPO*)Unsafe.AsPointer(ref this));
        }

        public void Process([NativeTypeName("UINT32")] uint InputProcessParameterCount, [NativeTypeName("const XAPO_PROCESS_BUFFER_PARAMETERS *")] XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters, [NativeTypeName("UINT32")] uint OutputProcessParameterCount, [NativeTypeName("XAPO_PROCESS_BUFFER_PARAMETERS *")] XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters, [NativeTypeName("BOOL")] int IsEnabled)
        {
            Marshal.GetDelegateForFunctionPointer<_Process>(lpVtbl->Process)((IXAPO*)Unsafe.AsPointer(ref this), InputProcessParameterCount, pInputProcessParameters, OutputProcessParameterCount, pOutputProcessParameters, IsEnabled);
        }

        [return: NativeTypeName("UINT32")]
        public uint CalcInputFrames([NativeTypeName("UINT32")] uint OutputFrameCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_CalcInputFrames>(lpVtbl->CalcInputFrames)((IXAPO*)Unsafe.AsPointer(ref this), OutputFrameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint CalcOutputFrames([NativeTypeName("UINT32")] uint InputFrameCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_CalcOutputFrames>(lpVtbl->CalcOutputFrames)((IXAPO*)Unsafe.AsPointer(ref this), InputFrameCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (XAPO_REGISTRATION_PROPERTIES **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRegistrationProperties;

            [NativeTypeName("HRESULT (const WAVEFORMATEX *, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsInputFormatSupported;

            [NativeTypeName("HRESULT (const WAVEFORMATEX *, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsOutputFormatSupported;

            [NativeTypeName("HRESULT (const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Initialize;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Reset;

            [NativeTypeName("HRESULT (UINT32, const XAPO_LOCKFORPROCESS_PARAMETERS *, UINT32, const XAPO_LOCKFORPROCESS_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr LockForProcess;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr UnlockForProcess;

            [NativeTypeName("void (UINT32, const XAPO_PROCESS_BUFFER_PARAMETERS *, UINT32, XAPO_PROCESS_BUFFER_PARAMETERS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Process;

            [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CalcInputFrames;

            [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CalcOutputFrames;
        }
    }
}
