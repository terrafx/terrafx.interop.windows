// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebAuthenticationCoreManagerInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F4B8E804-811E-4436-B69C-44CB67B72084")]
    [NativeTypeName("struct IWebAuthenticationCoreManagerInterop : IInspectable")]
    public unsafe partial struct IWebAuthenticationCoreManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint>)(lpVtbl[1]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint>)(lpVtbl[2]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, IntPtr*, int>)(lpVtbl[4]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestTokenForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("IInspectable *")] IInspectable* request, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** asyncInfo)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, IntPtr, IInspectable*, Guid*, void**, int>)(lpVtbl[6]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), appWindow, request, riid, asyncInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestTokenWithWebAccountForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("IInspectable *")] IInspectable* request, [NativeTypeName("IInspectable *")] IInspectable* webAccount, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** asyncInfo)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, IntPtr, IInspectable*, IInspectable*, Guid*, void**, int>)(lpVtbl[7]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), appWindow, request, webAccount, riid, asyncInfo);
        }
    }
}
