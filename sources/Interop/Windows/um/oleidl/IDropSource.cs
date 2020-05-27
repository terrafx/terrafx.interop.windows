// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000121-0000-0000-C000-000000000046")]
    public unsafe partial struct IDropSource
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDropSource* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDropSource* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDropSource* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryContinueDrag(IDropSource* pThis, [NativeTypeName("BOOL")] int fEscapePressed, [NativeTypeName("DWORD")] uint grfKeyState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GiveFeedback(IDropSource* pThis, [NativeTypeName("DWORD")] uint dwEffect);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDropSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDropSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDropSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryContinueDrag([NativeTypeName("BOOL")] int fEscapePressed, [NativeTypeName("DWORD")] uint grfKeyState)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryContinueDrag>(lpVtbl->QueryContinueDrag)((IDropSource*)Unsafe.AsPointer(ref this), fEscapePressed, grfKeyState);
        }

        [return: NativeTypeName("HRESULT")]
        public int GiveFeedback([NativeTypeName("DWORD")] uint dwEffect)
        {
            return Marshal.GetDelegateForFunctionPointer<_GiveFeedback>(lpVtbl->GiveFeedback)((IDropSource*)Unsafe.AsPointer(ref this), dwEffect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (BOOL, DWORD) __attribute__((stdcall))")]
            public IntPtr QueryContinueDrag;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr GiveFeedback;
        }
    }
}
