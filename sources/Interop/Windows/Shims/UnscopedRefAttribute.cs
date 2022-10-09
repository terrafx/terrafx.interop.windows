// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsageAttribute(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter, Inherited = false)]
internal sealed class UnscopedRefAttribute : Attribute
{
}
