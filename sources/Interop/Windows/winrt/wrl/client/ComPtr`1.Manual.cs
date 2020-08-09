// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/wrl/client.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public unsafe partial struct ComPtr<T> : IDisposable
        where T : unmanaged
    {
        private T* ptr_;

        public ComPtr(T* other)
        {
            ptr_ = other;
            InternalAddRef();
        }

        public ComPtr(ComPtr<T> other)
        {
            ptr_ = other.ptr_;
            InternalAddRef();
        }

        public static implicit operator ComPtr<T>(T* other)
        {
            return new ComPtr<T>(other);
        }

        public static implicit operator T*(ComPtr<T> other)
        {
            return other.Get();
        }

        public readonly int As<U>(ComPtr<U>* p)
            where U : unmanaged
        {
            var iid = typeof(U).GUID;
            return ((IUnknown*)(ptr_))->QueryInterface(&iid, (void**)(p->ReleaseAndGetAddressOf()));
        }

        public readonly int AsIID(Guid* riid, ComPtr<IUnknown>* p)
        {
            return ((IUnknown*)(ptr_))->QueryInterface(riid, (void**)(p->ReleaseAndGetAddressOf()));
        }

        public void Attach(T* other)
        {
            if (ptr_ != null)
            {
                var @ref = ((IUnknown*)(ptr_))->Release();
                Debug.Assert((@ref != 0) || (ptr_ != other));
            }
            ptr_ = other;
        }

        public readonly int CopyTo(T** ptr)
        {
            InternalAddRef();
            *ptr = ptr_;
            return S_OK;
        }

        public readonly int CopyTo(Guid* riid, void** ptr)
        {
            return ((IUnknown*)(ptr_))->QueryInterface(riid, ptr);
        }

        public readonly int CopyTo<U>(U** ptr)
            where U : unmanaged
        {
            var iid = typeof(U).GUID;
            return ((IUnknown*)(ptr_))->QueryInterface(&iid, (void**)(ptr));
        }

        public T* Detach()
        {
            T* ptr = ptr_;
            ptr_ = null;
            return ptr;
        }

        public void Dispose()
        {
            InternalRelease();
        }

        public readonly T* Get()
        {
            return ptr_;
        }

        public readonly T** GetAddressOf()
        {
            fixed (T** ptr = &ptr_)
            {
                return ptr;
            }
        }

        public readonly ref T* GetPinnableReference()
        {
            fixed (T** ptr = &ptr_)
            {
                return ref *ptr;
            }
        }

        public T** ReleaseAndGetAddressOf()
        {
            InternalRelease();
            return GetAddressOf();
        }

        public uint Reset()
        {
            return InternalRelease();
        }

        public void Swap(ref ComPtr<T> r)
        {
            T* tmp = ptr_;
            ptr_ = r.ptr_;
            r.ptr_ = tmp;
        }

        private readonly void InternalAddRef()
        {
            if (ptr_ != null)
            {
                ((IUnknown*)(ptr_))->AddRef();
            }
        }

        private uint InternalRelease()
        {
            uint @ref = 0;
            T* temp = ptr_;

            if (temp != null)
            {
                ptr_ = null;
                @ref = ((IUnknown*)(temp))->Release();
            }

            return @ref;
        }
    }
}
