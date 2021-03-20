// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4FF93A75-4145-47FF-AC7F-DFF1C1FA5B0F")]
    [NativeTypeName("struct IUICommand : IInspectable")]
    public unsafe partial struct IUICommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUICommand*, Guid*, void**, int>)(lpVtbl[0]))((IUICommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUICommand*, uint>)(lpVtbl[1]))((IUICommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUICommand*, uint>)(lpVtbl[2]))((IUICommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUICommand*, uint*, Guid**, int>)(lpVtbl[3]))((IUICommand*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUICommand*, IntPtr*, int>)(lpVtbl[4]))((IUICommand*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUICommand*, TrustLevel*, int>)(lpVtbl[5]))((IUICommand*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Label([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUICommand*, IntPtr*, int>)(lpVtbl[6]))((IUICommand*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Label([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IUICommand*, IntPtr, int>)(lpVtbl[7]))((IUICommand*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Invoked([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value)
        {
            return ((delegate* unmanaged<IUICommand*, IUICommandInvokedHandler**, int>)(lpVtbl[8]))((IUICommand*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Invoked([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value)
        {
            return ((delegate* unmanaged<IUICommand*, IUICommandInvokedHandler*, int>)(lpVtbl[9]))((IUICommand*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("IInspectable **")] IInspectable** value)
        {
            return ((delegate* unmanaged<IUICommand*, IInspectable**, int>)(lpVtbl[10]))((IUICommand*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Id([NativeTypeName("IInspectable *")] IInspectable* value)
        {
            return ((delegate* unmanaged<IUICommand*, IInspectable*, int>)(lpVtbl[11]))((IUICommand*)Unsafe.AsPointer(ref this), value);
        }
    }
}
