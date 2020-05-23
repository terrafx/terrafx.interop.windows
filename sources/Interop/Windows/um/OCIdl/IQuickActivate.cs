// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF51ED10-62FE-11CF-BF86-00A0C9034836")]
    public unsafe partial struct IQuickActivate
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IQuickActivate* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IQuickActivate* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IQuickActivate* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QuickActivate(IQuickActivate* pThis, [NativeTypeName("QACONTAINER *")] QACONTAINER* pQaContainer, [NativeTypeName("QACONTROL *")] QACONTROL* pQaControl);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetContentExtent(IQuickActivate* pThis, [NativeTypeName("LPSIZEL")] SIZE* pSizel);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContentExtent(IQuickActivate* pThis, [NativeTypeName("LPSIZEL")] SIZE* pSizel);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IQuickActivate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IQuickActivate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IQuickActivate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QuickActivate([NativeTypeName("QACONTAINER *")] QACONTAINER* pQaContainer, [NativeTypeName("QACONTROL *")] QACONTROL* pQaControl)
        {
            return Marshal.GetDelegateForFunctionPointer<_QuickActivate>(lpVtbl->QuickActivate)((IQuickActivate*)Unsafe.AsPointer(ref this), pQaContainer, pQaControl);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetContentExtent>(lpVtbl->SetContentExtent)((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContentExtent>(lpVtbl->GetContentExtent)((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (QACONTAINER *, QACONTROL *) __attribute__((stdcall))")]
            public IntPtr QuickActivate;

            [NativeTypeName("HRESULT (LPSIZEL) __attribute__((stdcall))")]
            public IntPtr SetContentExtent;

            [NativeTypeName("HRESULT (LPSIZEL) __attribute__((stdcall))")]
            public IntPtr GetContentExtent;
        }
    }
}
