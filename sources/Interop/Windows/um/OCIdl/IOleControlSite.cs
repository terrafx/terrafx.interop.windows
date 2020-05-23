// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B289-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IOleControlSite
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleControlSite* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleControlSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleControlSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnControlInfoChanged(IOleControlSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockInPlaceActive(IOleControlSite* pThis, [NativeTypeName("BOOL")] int fLock);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetExtendedControl(IOleControlSite* pThis, [NativeTypeName("IDispatch **")] IDispatch** ppDisp);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TransformCoords(IOleControlSite* pThis, [NativeTypeName("POINTL *")] POINTL* pPtlHimetric, [NativeTypeName("POINTF *")] POINTF* pPtfContainer, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TranslateAcceleratorA(IOleControlSite* pThis, [NativeTypeName("MSG *")] MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnFocus(IOleControlSite* pThis, [NativeTypeName("BOOL")] int fGotFocus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ShowPropertyFrame(IOleControlSite* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleControlSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnControlInfoChanged()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnControlInfoChanged>(lpVtbl->OnControlInfoChanged)((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockInPlaceActive([NativeTypeName("BOOL")] int fLock)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockInPlaceActive>(lpVtbl->LockInPlaceActive)((IOleControlSite*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtendedControl([NativeTypeName("IDispatch **")] IDispatch** ppDisp)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExtendedControl>(lpVtbl->GetExtendedControl)((IOleControlSite*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [return: NativeTypeName("HRESULT")]
        public int TransformCoords([NativeTypeName("POINTL *")] POINTL* pPtlHimetric, [NativeTypeName("POINTF *")] POINTF* pPtfContainer, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_TransformCoords>(lpVtbl->TransformCoords)((IOleControlSite*)Unsafe.AsPointer(ref this), pPtlHimetric, pPtfContainer, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorA([NativeTypeName("MSG *")] MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
        {
            return Marshal.GetDelegateForFunctionPointer<_TranslateAcceleratorA>(lpVtbl->TranslateAcceleratorA)((IOleControlSite*)Unsafe.AsPointer(ref this), pMsg, grfModifiers);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFocus([NativeTypeName("BOOL")] int fGotFocus)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnFocus>(lpVtbl->OnFocus)((IOleControlSite*)Unsafe.AsPointer(ref this), fGotFocus);
        }

        [return: NativeTypeName("HRESULT")]
        public int ShowPropertyFrame()
        {
            return Marshal.GetDelegateForFunctionPointer<_ShowPropertyFrame>(lpVtbl->ShowPropertyFrame)((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr OnControlInfoChanged;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr LockInPlaceActive;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public IntPtr GetExtendedControl;

            [NativeTypeName("HRESULT (POINTL *, POINTF *, DWORD) __attribute__((stdcall))")]
            public IntPtr TransformCoords;

            [NativeTypeName("HRESULT (MSG *, DWORD) __attribute__((stdcall))")]
            public IntPtr TranslateAcceleratorA;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr OnFocus;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr ShowPropertyFrame;
        }
    }
}
