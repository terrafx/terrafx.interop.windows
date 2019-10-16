// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("63AC0B32-BA44-450F-8806-7F4CA1FF2F1B")]
    public unsafe partial struct ID2D1BlendTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1BlendTransform* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1BlendTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1BlendTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1BlendTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputBuffer(ID2D1BlendTransform* pThis, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetCached(ID2D1BlendTransform* pThis, [NativeTypeName("BOOL")] int isCached);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDescription(ID2D1BlendTransform* pThis, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDescription(ID2D1BlendTransform* pThis, [NativeTypeName("D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOutputBuffer>(lpVtbl->SetOutputBuffer)((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            Marshal.GetDelegateForFunctionPointer<_SetCached>(lpVtbl->SetCached)((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), isCached);
        }

        public void SetDescription([NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description)
        {
            Marshal.GetDelegateForFunctionPointer<_SetDescription>(lpVtbl->SetDescription)((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
        }

        public void GetDescription([NativeTypeName("D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInputCount;

            [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOutputBuffer;

            [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCached;

            [NativeTypeName("void (const D2D1_BLEND_DESCRIPTION *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetDescription;

            [NativeTypeName("void (D2D1_BLEND_DESCRIPTION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDescription;
        }
    }
}
