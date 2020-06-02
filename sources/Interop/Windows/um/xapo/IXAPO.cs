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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXAPO*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRegistrationProperties([NativeTypeName("XAPO_REGISTRATION_PROPERTIES **")] XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties)
        {
            return lpVtbl->GetRegistrationProperties((IXAPO*)Unsafe.AsPointer(ref this), ppRegistrationProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsInputFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pOutputFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedInputFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppSupportedInputFormat)
        {
            return lpVtbl->IsInputFormatSupported((IXAPO*)Unsafe.AsPointer(ref this), pOutputFormat, pRequestedInputFormat, ppSupportedInputFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsOutputFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pInputFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedOutputFormat, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppSupportedOutputFormat)
        {
            return lpVtbl->IsOutputFormatSupported((IXAPO*)Unsafe.AsPointer(ref this), pInputFormat, pRequestedOutputFormat, ppSupportedOutputFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT32")] uint DataByteSize)
        {
            return lpVtbl->Initialize((IXAPO*)Unsafe.AsPointer(ref this), pData, DataByteSize);
        }

        public void Reset()
        {
            lpVtbl->Reset((IXAPO*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockForProcess([NativeTypeName("UINT32")] uint InputLockedParameterCount, [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")] XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pInputLockedParameters, [NativeTypeName("UINT32")] uint OutputLockedParameterCount, [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")] XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS* pOutputLockedParameters)
        {
            return lpVtbl->LockForProcess((IXAPO*)Unsafe.AsPointer(ref this), InputLockedParameterCount, pInputLockedParameters, OutputLockedParameterCount, pOutputLockedParameters);
        }

        public void UnlockForProcess()
        {
            lpVtbl->UnlockForProcess((IXAPO*)Unsafe.AsPointer(ref this));
        }

        public void Process([NativeTypeName("UINT32")] uint InputProcessParameterCount, [NativeTypeName("const XAPO_PROCESS_BUFFER_PARAMETERS *")] XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters, [NativeTypeName("UINT32")] uint OutputProcessParameterCount, [NativeTypeName("XAPO_PROCESS_BUFFER_PARAMETERS *")] XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters, [NativeTypeName("BOOL")] int IsEnabled)
        {
            lpVtbl->Process((IXAPO*)Unsafe.AsPointer(ref this), InputProcessParameterCount, pInputProcessParameters, OutputProcessParameterCount, pOutputProcessParameters, IsEnabled);
        }

        [return: NativeTypeName("UINT32")]
        public uint CalcInputFrames([NativeTypeName("UINT32")] uint OutputFrameCount)
        {
            return lpVtbl->CalcInputFrames((IXAPO*)Unsafe.AsPointer(ref this), OutputFrameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint CalcOutputFrames([NativeTypeName("UINT32")] uint InputFrameCount)
        {
            return lpVtbl->CalcOutputFrames((IXAPO*)Unsafe.AsPointer(ref this), InputFrameCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, uint> Release;

            [NativeTypeName("HRESULT (XAPO_REGISTRATION_PROPERTIES **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, XAPO_REGISTRATION_PROPERTIES**, int> GetRegistrationProperties;

            [NativeTypeName("HRESULT (const WAVEFORMATEX *, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, WAVEFORMATEX*, WAVEFORMATEX*, WAVEFORMATEX**, int> IsInputFormatSupported;

            [NativeTypeName("HRESULT (const WAVEFORMATEX *, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, WAVEFORMATEX*, WAVEFORMATEX*, WAVEFORMATEX**, int> IsOutputFormatSupported;

            [NativeTypeName("HRESULT (const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, void*, uint, int> Initialize;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, void> Reset;

            [NativeTypeName("HRESULT (UINT32, const XAPO_LOCKFORPROCESS_PARAMETERS *, UINT32, const XAPO_LOCKFORPROCESS_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, uint, XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS*, uint, XAPO_LOCKFORPROCESS_BUFFER_PARAMETERS*, int> LockForProcess;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, void> UnlockForProcess;

            [NativeTypeName("void (UINT32, const XAPO_PROCESS_BUFFER_PARAMETERS *, UINT32, XAPO_PROCESS_BUFFER_PARAMETERS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, uint, XAPO_PROCESS_BUFFER_PARAMETERS*, uint, XAPO_PROCESS_BUFFER_PARAMETERS*, int, void> Process;

            [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, uint, uint> CalcInputFrames;

            [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPO*, uint, uint> CalcOutputFrames;
        }
    }
}
