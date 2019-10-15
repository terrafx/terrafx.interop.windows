// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("689F1F85-C72E-4E33-8F19-85754EFD5ACE")]
    public unsafe partial struct ID2D1DrawingStateBlock1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1DrawingStateBlock1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1DrawingStateBlock1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1DrawingStateBlock1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1DrawingStateBlock1* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDescription(ID2D1DrawingStateBlock1* pThis, [NativeTypeName("D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDescription(ID2D1DrawingStateBlock1* pThis, [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextRenderingParams(ID2D1DrawingStateBlock1* pThis, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTextRenderingParams(ID2D1DrawingStateBlock1* pThis, [NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDescription1(ID2D1DrawingStateBlock1* pThis, [NativeTypeName("D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDescription1(ID2D1DrawingStateBlock1* pThis, [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetDescription([NativeTypeName("D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            Marshal.GetDelegateForFunctionPointer<_SetDescription>(lpVtbl->SetDescription)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public void SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams)
        {
            Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void GetTextRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams)
        {
            Marshal.GetDelegateForFunctionPointer<_GetTextRenderingParams>(lpVtbl->GetTextRenderingParams)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void GetDescription([NativeTypeName("D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDescription1>(lpVtbl->GetDescription1)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            Marshal.GetDelegateForFunctionPointer<_SetDescription1>(lpVtbl->SetDescription1)((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("void (D2D1_DRAWING_STATE_DESCRIPTION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDescription;

            [NativeTypeName("void (const D2D1_DRAWING_STATE_DESCRIPTION *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetDescription;

            [NativeTypeName("void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetTextRenderingParams;

            [NativeTypeName("void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetTextRenderingParams;

            [NativeTypeName("void (D2D1_DRAWING_STATE_DESCRIPTION1 *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDescription1;

            [NativeTypeName("void (const D2D1_DRAWING_STATE_DESCRIPTION1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetDescription1;
        }
    }
}
