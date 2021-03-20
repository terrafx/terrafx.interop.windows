// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2D161777-A66F-4EA5-BB87-793FFA4941F2")]
    [NativeTypeName("struct IMessageDialogFactory : IInspectable")]
    public unsafe partial struct IMessageDialogFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMessageDialogFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMessageDialogFactory*, uint>)(lpVtbl[1]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMessageDialogFactory*, uint>)(lpVtbl[2]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMessageDialogFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMessageDialogFactory*, IntPtr*, int>)(lpVtbl[4]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMessageDialogFactory*, TrustLevel*, int>)(lpVtbl[5]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("HSTRING")] IntPtr content, [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")] IMessageDialog** messageDialog)
        {
            return ((delegate* unmanaged<IMessageDialogFactory*, IntPtr, IMessageDialog**, int>)(lpVtbl[6]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), content, messageDialog);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithTitle([NativeTypeName("HSTRING")] IntPtr content, [NativeTypeName("HSTRING")] IntPtr title, [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")] IMessageDialog** messageDialog)
        {
            return ((delegate* unmanaged<IMessageDialogFactory*, IntPtr, IntPtr, IMessageDialog**, int>)(lpVtbl[7]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), content, title, messageDialog);
        }
    }
}
