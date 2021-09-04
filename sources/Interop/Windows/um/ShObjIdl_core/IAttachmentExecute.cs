// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73DB1241-1E85-4581-8E4F-A81E1D0F8C57")]
    [NativeTypeName("struct IAttachmentExecute : IUnknown")]
    public unsafe partial struct IAttachmentExecute
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, Guid*, void**, int>)(lpVtbl[0]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAttachmentExecute*, uint>)(lpVtbl[1]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAttachmentExecute*, uint>)(lpVtbl[2]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClientTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[3]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, Guid*, int>)(lpVtbl[4]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLocalPath([NativeTypeName("LPCWSTR")] ushort* pszLocalPath)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[5]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszLocalPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFileName([NativeTypeName("LPCWSTR")] ushort* pszFileName)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[6]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszFileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("LPCWSTR")] ushort* pszSource)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[7]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetReferrer([NativeTypeName("LPCWSTR")] ushort* pszReferrer)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, ushort*, int>)(lpVtbl[8]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), pszReferrer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckPolicy()
        {
            return ((delegate* unmanaged<IAttachmentExecute*, int>)(lpVtbl[9]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Prompt([NativeTypeName("HWND")] IntPtr hwnd, ATTACHMENT_PROMPT prompt, ATTACHMENT_ACTION* paction)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, IntPtr, ATTACHMENT_PROMPT, ATTACHMENT_ACTION*, int>)(lpVtbl[10]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), hwnd, prompt, paction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save()
        {
            return ((delegate* unmanaged<IAttachmentExecute*, int>)(lpVtbl[11]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Execute([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszVerb, [NativeTypeName("HANDLE *")] IntPtr* phProcess)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, IntPtr, ushort*, IntPtr*, int>)(lpVtbl[12]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), hwnd, pszVerb, phProcess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveWithUI([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<IAttachmentExecute*, IntPtr, int>)(lpVtbl[13]))((IAttachmentExecute*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearClientState()
        {
            return ((delegate* unmanaged<IAttachmentExecute*, int>)(lpVtbl[14]))((IAttachmentExecute*)Unsafe.AsPointer(ref this));
        }
    }
}
