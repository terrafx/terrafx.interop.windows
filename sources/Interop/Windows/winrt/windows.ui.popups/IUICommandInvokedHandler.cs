// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DAF77A4F-C27A-4298-9AC6-2922C45E7DA6")]
    [NativeTypeName("struct IUICommandInvokedHandler : IUnknown")]
    public unsafe partial struct IUICommandInvokedHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUICommandInvokedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUICommandInvokedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUICommandInvokedHandler*, uint>)(lpVtbl[1]))((IUICommandInvokedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUICommandInvokedHandler*, uint>)(lpVtbl[2]))((IUICommandInvokedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("ABI::Windows::UI::Popups::IUICommand *")] IUICommand* command)
        {
            return ((delegate* unmanaged<IUICommandInvokedHandler*, IUICommand*, int>)(lpVtbl[3]))((IUICommandInvokedHandler*)Unsafe.AsPointer(ref this), command);
        }
    }
}
