// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28C-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IPropertyPageSite
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPropertyPageSite* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPropertyPageSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPropertyPageSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnStatusChange(IPropertyPageSite* pThis, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleID(IPropertyPageSite* pThis, [NativeTypeName("LCID *")] uint* pLocaleID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPageContainer(IPropertyPageSite* pThis, [NativeTypeName("IUnknown **")] IUnknown** ppUnk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TranslateAcceleratorA(IPropertyPageSite* pThis, [NativeTypeName("MSG *")] MSG* pMsg);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPropertyPageSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPropertyPageSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPropertyPageSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnStatusChange>(lpVtbl->OnStatusChange)((IPropertyPageSite*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleID([NativeTypeName("LCID *")] uint* pLocaleID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleID>(lpVtbl->GetLocaleID)((IPropertyPageSite*)Unsafe.AsPointer(ref this), pLocaleID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPageContainer([NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPageContainer>(lpVtbl->GetPageContainer)((IPropertyPageSite*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return Marshal.GetDelegateForFunctionPointer<_TranslateAcceleratorA>(lpVtbl->TranslateAcceleratorA)((IPropertyPageSite*)Unsafe.AsPointer(ref this), pMsg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr OnStatusChange;

            [NativeTypeName("HRESULT (LCID *) __attribute__((stdcall))")]
            public IntPtr GetLocaleID;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public IntPtr GetPageContainer;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public IntPtr TranslateAcceleratorA;
        }
    }
}
