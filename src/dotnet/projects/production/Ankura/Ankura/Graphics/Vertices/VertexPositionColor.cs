// Copyright (c) Craftwork Games. All rights reserved.
// Licensed under the MS-PL license. See LICENSE file in the Git repository root directory for full license information.

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Ankura
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VertexPositionColor : IVertexType
    {
        VertexDeclaration IVertexType.VertexDeclaration => VertexDeclaration;

        public Vector3 Position;

        public Color Color;

        public static readonly VertexDeclaration VertexDeclaration;

        static VertexPositionColor()
        {
            VertexDeclaration = new VertexDeclaration(
                new VertexElement(0, VertexElementFormat.Vector3, VertexElementUsage.Position, 0),
                new VertexElement(12, VertexElementFormat.Color, VertexElementUsage.Color, 0));
        }

        public VertexPositionColor(Vector3 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override int GetHashCode()
        {
            // TODO: Fix GetHashCode
            return 0;
        }

        public override string ToString()
        {
            return "{{Position:" + Position +
                   " Color:" + Color +
                   "}}";
        }

        public static bool operator ==(VertexPositionColor left, VertexPositionColor right)
        {
            return left.Color == right.Color &&
                   left.Position == right.Position;
        }

        public static bool operator !=(VertexPositionColor left, VertexPositionColor right)
        {
            return !(left == right);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return this == (VertexPositionColor)obj;
        }
    }
}
