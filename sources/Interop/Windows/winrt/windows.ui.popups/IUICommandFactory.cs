// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A21A8189-26B0-4676-AE94-54041BC125E8")]
    [NativeTypeName("struct IUICommandFactory : IInspectable")]
    public unsafe partial struct IUICommandFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUICommandFactory*, Guid*, void**, int>)(lpVtbl[0]))((IUICommandFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUICommandFactory*, uint>)(lpVtbl[1]))((IUICommandFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUICommandFactory*, uint>)(lpVtbl[2]))((IUICommandFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUICommandFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IUICommandFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUICommandFactory*, IntPtr*, int>)(lpVtbl[4]))((IUICommandFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUICommandFactory*, TrustLevel*, int>)(lpVtbl[5]))((IUICommandFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("HSTRING")] IntPtr label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance)
        {
            return ((delegate* unmanaged<IUICommandFactory*, IntPtr, IUICommand**, int>)(lpVtbl[6]))((IUICommandFactory*)Unsafe.AsPointer(ref this), label, instance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithHandler([NativeTypeName("HSTRING")] IntPtr label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* action, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance)
        {
            return ((delegate* unmanaged<IUICommandFactory*, IntPtr, IUICommandInvokedHandler*, IUICommand**, int>)(lpVtbl[7]))((IUICommandFactory*)Unsafe.AsPointer(ref this), label, action, instance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithHandlerAndId([NativeTypeName("HSTRING")] IntPtr label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* action, [NativeTypeName("IInspectable *")] IInspectable* commandId, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance)
        {
            return ((delegate* unmanaged<IUICommandFactory*, IntPtr, IUICommandInvokedHandler*, IInspectable*, IUICommand**, int>)(lpVtbl[8]))((IUICommandFactory*)Unsafe.AsPointer(ref this), label, action, commandId, instance);
        }
    }
}
