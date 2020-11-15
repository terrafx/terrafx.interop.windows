// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/wrl/client.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    /// <summary>
    /// A type that allows working with pointers to COM objects more securely.
    /// </summary>
    /// <typeparam name="T">The type to wrap in the current <see cref="ComPtr{T}"/> instance.</typeparam>
    /// <remarks>
    /// While this type is not marked as <see langword="ref"/> so that it can also be used in fields, make sure
    /// to keep the reference counts properly tracked if you do store <see cref="ComPtr{T}"/> instances on the heap.
    /// </remarks>
    public unsafe struct ComPtr<T> : IDisposable
        where T : unmanaged
    {
        /// <summary>
        /// The raw pointer to a COM object, if existing.
        /// </summary>
        private T* pointer;

        /// <summary>
        /// Gets a pointer to the <see cref="Guid"/> value for the current type.
        /// </summary>
        /// <remarks>The target memory area should never be written to.</remarks>
        public static readonly Guid* RIID = CreateRIID();

        /// <summary>
        /// Creates a new <see cref="ComPtr{T}"/> instance from a raw pointer and increments the ref count.
        /// </summary>
        /// <param name="other">The raw pointer to wrap.</param>
        public ComPtr(T* other)
        {
            this.pointer = other;

            InternalAddRef();
        }

        /// <summary>
        /// Creates a new <see cref="ComPtr{T}"/> instance from a second one and increments the ref count.
        /// </summary>
        /// <param name="other">The other <see cref="ComPtr{T}"/> instance to copy.</param>
        public ComPtr(ComPtr<T> other)
        {
            this.pointer = other.pointer;

            InternalAddRef();
        }

        /// <summary>
        /// Converts a raw pointer to a new <see cref="ComPtr{T}"/> instance and increments the ref count.
        /// </summary>
        /// <param name="other">The raw pointer to wrap.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ComPtr<T>(T* other)
        {
            return new(other);
        }

        /// <summary>
        /// Unwraps a <see cref="ComPtr{T}"/> instance and returns the internal raw pointer.
        /// </summary>
        /// <param name="other">The <see cref="ComPtr{T}"/> instance to unwrap.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator T*(ComPtr<T> other)
        {
            return other.Get();
        }

        /// <summary>
        /// Converts the current object reference to type <typeparamref name="U"/> and assigns that to a target <see cref="ComPtr{T}"/> value.
        /// </summary>
        /// <typeparam name="U">The interface type to use to try casting the current COM object.</typeparam>
        /// <param name="p">A raw pointer to the target <see cref="ComPtr{T}"/> value to write to.</param>
        /// <returns>The result of <see cref="IUnknown.QueryInterface"/> for the target type <typeparamref name="U"/>.</returns>
        /// <remarks>This method will automatically release the target COM object pointed to by <paramref name="p"/>, if any.</remarks>
        public readonly int As<U>(ComPtr<U>* p)
            where U : unmanaged
        {
            return ((IUnknown*)this.pointer)->QueryInterface(ComPtr<U>.RIID, (void**)p->ReleaseAndGetAddressOf());
        }

        /// <summary>
        /// Converts the current object reference to a type indicated by the given IID and assigns that to a target <see cref="ComPtr{T}"/> value.
        /// </summary>
        /// <param name="riid">The IID indicating the interface type to convert the COM object reference to.</param>
        /// <param name="p">A raw pointer to the target <see cref="ComPtr{T}"/> value to write to.</param>
        /// <returns>The result of <see cref="IUnknown.QueryInterface"/> for the target IID.</returns>
        /// <remarks>This method will automatically release the target COM object pointed to by <paramref name="p"/>, if any.</remarks>
        public readonly int AsIID(Guid* riid, ComPtr<IUnknown>* p)
        {
            return ((IUnknown*)this.pointer)->QueryInterface(riid, (void**)p->ReleaseAndGetAddressOf());
        }

        /// <summary>
        /// Releases the current COM object, if any, and replaces the internal pointer with an input raw pointer.
        /// </summary>
        /// <param name="other">The input raw pointer to wrap.</param>
        /// <remarks>This method will release the current raw pointer, if any, but it will not increment the references for <paramref name="other"/>.</remarks>
        public void Attach(T* other)
        {
            if (this.pointer != null)
            {
                var @ref = ((IUnknown*)this.pointer)->Release();

                Debug.Assert((@ref != 0) || (this.pointer != other));
            }

            this.pointer = other;
        }

        /// <summary>
        /// Returns the raw pointer wrapped by the current instance, and resets the current <see cref="ComPtr{T}"/> value.
        /// </summary>
        /// <returns>The raw pointer wrapped by the current <see cref="ComPtr{T}"/> value.</returns>
        /// <remarks>This method will not change the reference count for the COM object in use.</remarks>
        public T* Detach()
        {
            T* ptr = this.pointer;

            this.pointer = null;

            return ptr;
        }

        /// <summary>
        /// Increments the reference count for the current COM object, if any, and copies its address to a target raw pointer.
        /// </summary>
        /// <param name="ptr">The target raw pointer to copy the address of the current COM object to.</param>
        /// <returns>This method always returns <see cref="S_OK"/>.</returns>
        public readonly int CopyTo(T** ptr)
        {
            InternalAddRef();

            *ptr = this.pointer;

            return S_OK;
        }

        /// <summary>
        /// Converts the current COM object reference to a given interface type and assigns that to a target raw pointer.
        /// </summary>
        /// <param name="ptr">The target raw pointer to copy the address of the current COM object to.</param>
        /// <returns>The result of <see cref="IUnknown.QueryInterface"/> for the target type <typeparamref name="U"/>.</returns>
        public readonly int CopyTo<U>(U** ptr)
            where U : unmanaged
        {
            return ((IUnknown*)this.pointer)->QueryInterface(ComPtr<U>.RIID, (void**)ptr);
        }

        /// <summary>
        /// Converts the current object reference to a type indicated by the given IID and assigns that to a target <see cref="ComPtr{T}"/> value.
        /// </summary>
        /// <param name="riid">The IID indicating the interface type to convert the COM object reference to.</param>
        /// <param name="ptr">The target raw pointer to copy the address of the current COM object to.</param>
        /// <returns>The result of <see cref="IUnknown.QueryInterface"/> for the target IID.</returns>
        public readonly int CopyTo(Guid* riid, void** ptr)
        {
            return ((IUnknown*)this.pointer)->QueryInterface(riid, ptr);
        }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            T* pointer = this.pointer;

            if (pointer != null)
            {
                this.pointer = null;

                _ = ((IUnknown*)pointer)->Release();
            }
        }

        /// <summary>
        /// Gets the currently wrapped raw pointer to a COM object.
        /// </summary>
        /// <returns>The raw pointer wrapped by the current <see cref="ComPtr{T}"/> instance.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T* Get()
        {
            return this.pointer;
        }

        /// <summary>
        /// Gets the address of the current <see cref="ComPtr{T}"/> instance as a raw <typeparamref name="T"/> double pointer.
        /// </summary>
        /// <returns>The raw pointer to the current <see cref="ComPtr{T}"/> instance.</returns>
        /// <remarks>This method is only valid when the current <see cref="ComPtr{T}"/> instance is on the stack or pinned.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T** GetAddressOf()
        {
            return (T**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        }

        /// <summary>
        /// Gets the address of the current <see cref="ComPtr{T}"/> instance as a raw <typeparamref name="T"/> double pointer.
        /// </summary>
        /// <returns>The raw pointer to the current <see cref="ComPtr{T}"/> instance.</returns>
        /// <remarks>This method is only valid when the current <see cref="ComPtr{T}"/> instance is on the stack or pinned.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public readonly ref T* GetPinnableReference()
        {
            return ref *(T**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
        }

        /// <summary>
        /// Releases the current COM object in use and gets the address of the <see cref="ComPtr{T}"/> instance as a raw <typeparamref name="T"/> double pointer.
        /// </summary>
        /// <returns>The raw pointer to the current <see cref="ComPtr{T}"/> instance.</returns>
        /// <remarks>This method is only valid when the current <see cref="ComPtr{T}"/> instance is on the stack or pinned.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T** ReleaseAndGetAddressOf()
        {
            InternalRelease();

            return GetAddressOf();
        }

        /// <summary>
        /// Resets the current instance by decrementing the reference count for the target COM object and setting the internal raw pointer to <see langword="null"/>.
        /// </summary>
        /// <returns>The updated reference count for the COM object that was in use, if any.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Reset()
        {
            return InternalRelease();
        }

        /// <summary>
        /// Swaps the current COM object reference with that of a given <see cref="ComPtr{T}"/> instance.
        /// </summary>
        /// <param name="r">The target <see cref="ComPtr{T}"/> instance to swap with the current one.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(ref ComPtr<T> r)
        {
            T* temp = this.pointer;

            this.pointer = r.pointer;

            r.pointer = temp;
        }

        // Increments the reference count for the current COM object, if any
        private readonly void InternalAddRef()
        {
            T* pointer = this.pointer;

            if (pointer != null)
            {
                ((IUnknown*)pointer)->AddRef();
            }
        }

        // Decrements the reference count for the current COM object, if any
        private uint InternalRelease()
        {
            uint referenceCount = 0;

            T* temp = pointer;

            if (temp != null)
            {
                this.pointer = null;

                referenceCount = ((IUnknown*)temp)->Release();
            }

            return referenceCount;
        }

        /// <summary>
        /// Allocates memory for a <see cref="Guid"/> value and initializes it.
        /// </summary>
        /// <returns>A pointer to memory holding the <see cref="Guid"/> value for the current type.</returns>
        private static Guid* CreateRIID()
        {
            Guid* p = (Guid*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(T), sizeof(Guid));

            *p = typeof(T).GUID;

            return p;
        }
    }
}
